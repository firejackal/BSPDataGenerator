using System;
using System.Windows.Forms;

namespace BSPDataGenerator
{
    public partial class MainForm : Form
    {
        public const int PartitionSize = 512 * 1024; //512KB

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            this.SerialTextBox.Text = "PM1LHMC000000000";

            //fill variant list.
            this.VariantCombo.Items.Clear();
            this.VariantCombo.Items.Add("");
            this.VariantCombo.Items.Add("OPENAM");
            this.VariantCombo.Items.Add("OPENUS");
            this.VariantCombo.Items.Add("SPRINT");
            this.VariantCombo.SelectedIndex = 2;
        }

        private void GenerateButton_Click(Object sender, EventArgs e)
        {
            if(this.SerialTextBox.TextLength == 0)
            {
                MessageBox.Show("Please enter a serial number.");
                return;
            }
            if (this.SerialTextBox.TextLength != 16)
            {
                MessageBox.Show("The serial number must be 16 characters in length.");
                return;
            }
            //dunno how long the variant is suppose to be. let's say 64 bytes (up to the next character in the file.)
            if (this.VariantCombo.Text.Length > 8)
            {
                MessageBox.Show("The variant name must be between 1 to 8 characters in length.");
                return;
            }

            ByteManipulator file = new ByteManipulator(PartitionSize);
            
            // insert data
            try
            {
                //0x0: Header
                file.InsertHex(ByteManipulator.HexToDec("0"), "44664D5F0200000005"); 
                //0xC: Product ID/Serial Number Header
                file.InsertText(ByteManipulator.HexToDec("C"), "productid");
                //0x1C: Product ID/Serial Number Text
                file.InsertText(ByteManipulator.HexToDec("1C"), this.SerialTextBox.Text);
                //0x5C: Product ID/Serial Number Length
                file.InsertByte(ByteManipulator.HexToDec("5C"), Convert.ToByte(this.SerialTextBox.Text.Length));
                //0x60: Magic
                file.InsertHex(ByteManipulator.HexToDec("60"), "01000000BC01");
                //0x68: Bluetooth MAC Address Header
                file.InsertText(ByteManipulator.HexToDec("68"), "bt_mac");
                //0xBC: Magic
                file.InsertHex(ByteManipulator.HexToDec("BC"), "01000000BC01");
                //0xC4: WiFi MAC Address Header
                file.InsertText(ByteManipulator.HexToDec("C4"), "wifi_mac");
                //0x118: Magic
                file.InsertHex(ByteManipulator.HexToDec("118"), "01000000BC01");
                //0x120: Variant Header
                file.InsertText(ByteManipulator.HexToDec("120"), "skuid");
                //0x130: Variant Text
                file.InsertText(ByteManipulator.HexToDec("130"), this.VariantCombo.Text);
                //0x170: Variant Length
                file.InsertByte(ByteManipulator.HexToDec("170"), Convert.ToByte(this.VariantCombo.Text.Length)); //this flag seems to be missing on other devices
                //0x174: Magic
                file.InsertHex(ByteManipulator.HexToDec("174"), "01000000BC01");
                //0x17C: Color Header
                file.InsertText(ByteManipulator.HexToDec("17C"), "color");
                //0x1D0: Magic
                file.InsertHex(ByteManipulator.HexToDec("1D0"), "01000000BC01");
                //0x1D8 to 0xFFF: Unknown Data #1
                file.InsertHex(ByteManipulator.HexToDec("1D8"), "AF", (ByteManipulator.HexToDec("FFF") - ByteManipulator.HexToDec("1D8")) + 1);
                //0x2000 to 0x2122: Unknown Data #2
                file.InsertHex(ByteManipulator.HexToDec("2000"), "FF", (ByteManipulator.HexToDec("2122") - ByteManipulator.HexToDec("2000")) + 1);
                //0x2123 to 0x2FFF: Unknown Data #3
                file.InsertHex(ByteManipulator.HexToDec("2123"), "AF", (ByteManipulator.HexToDec("2FFF") - ByteManipulator.HexToDec("2123")) + 1);
                //0x77000-0x77020 seems to be different per device. Might be a checksum.
                //0x77000
                file.InsertHex(ByteManipulator.HexToDec("77000"), "313830303000B0F7");
                //0x77010
                file.InsertHex(ByteManipulator.HexToDec("77010"), "36340000205941EA");
            } catch(Exception ex) {
                MessageBox.Show("Fatal error has occured generating the file:" + System.Environment.NewLine + ex.Message);
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "BSPData Partition";
            dialog.Filter = "bspdata|bspdata|Partition Images (*.img)|*.img|All Files (*.*)|*.*";
            dialog.FileName = "bspdata";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            if (file.SaveToFile(dialog.FileName))
            {
                MessageBox.Show("File saved successfully." + System.Environment.NewLine + "Now flash with either `fastboot flash bspdata`, or the dd command.");
            } else {
                MessageBox.Show("File unable to be saved.");
            }
        }

        private void RestoreButton_Click(Object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "BSPData Partition";
            dialog.Filter = "bspdata|bspdata|Partition Images (*.img)|*.img|All Files (*.*)|*.*";
            dialog.FileName = "bspdata";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            this.RestoreSettings(dialog.FileName);
        }

        private void RestoreSettings(string fileName)
        {
            try
            {
                byte[] data = System.IO.File.ReadAllBytes(fileName);

                //productid/serial number
                this.SerialTextBox.Text = ByteManipulator.ReadString(data, ByteManipulator.HexToDec("1C"));
                //variant
                this.VariantCombo.Text = ByteManipulator.ReadString(data, ByteManipulator.HexToDec("130"));
                //unknown flag #1
                //byte flag1 = ByteManipulator.ReadByte(data, ByteManipulator.HexToDec("170"));
                //this.VariantOnOffCheckBox.Checked = (flag1 == 6);
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to parse source file:" + System.Environment.NewLine + e.Message);
            }
        }
    }
}
