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
            this.VariantCombo.Items.Add("OPENUS");
            this.VariantCombo.Items.Add("SPRINT");
            this.VariantCombo.SelectedIndex = 1;
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
            if (this.VariantCombo.Text.Length > 64)
            {
                MessageBox.Show("Please enter a variant under 64 characters in length.");
                return;
            }

            ByteManipulator file = new ByteManipulator(PartitionSize);

            // insert data
            try
            {
                //0x0
                file.InsertHex(ByteManipulator.HexToDec("0"), "44664D5F0200000005"); 
                //0xC
                file.InsertText(ByteManipulator.HexToDec("C"), "productid"); 
                //0x1C
                file.InsertText(ByteManipulator.HexToDec("1C"), this.SerialTextBox.Text);
                //0x5C
                file.InsertHex(ByteManipulator.HexToDec("5C"), "10000000");
                //0x60
                file.InsertHex(ByteManipulator.HexToDec("60"), "01000000BC01");
                //0x68
                file.InsertText(ByteManipulator.HexToDec("68"), "bt_mac");
                //0xBC
                file.InsertHex(ByteManipulator.HexToDec("BC"), "01000000BC01");
                //0xC4
                file.InsertText(ByteManipulator.HexToDec("C4"), "wifi_mac");
                //0x118
                file.InsertHex(ByteManipulator.HexToDec("118"), "01000000BC01");
                //0x120
                file.InsertText(ByteManipulator.HexToDec("120"), "skuid");
                //0x130
                file.InsertText(ByteManipulator.HexToDec("130"), this.VariantCombo.Text);
                //0x170
                file.InsertHex(ByteManipulator.HexToDec("170"), "06");
                //0x174
                file.InsertHex(ByteManipulator.HexToDec("174"), "01000000BC01");
                //0x17C
                file.InsertText(ByteManipulator.HexToDec("17C"), "color");
                //0x1D0
                file.InsertHex(ByteManipulator.HexToDec("1D0"), "01000000BC01");
                //0x1D8 to 0xFFF
                file.InsertHex(ByteManipulator.HexToDec("1D8"), "AF", (ByteManipulator.HexToDec("FFF") - ByteManipulator.HexToDec("1D8")) + 1);
                //0x2000 to 0x2122
                file.InsertHex(ByteManipulator.HexToDec("2000"), "FF", (ByteManipulator.HexToDec("2122") - ByteManipulator.HexToDec("2000")) + 1);
                //0x2123 to 0x2FFF
                file.InsertHex(ByteManipulator.HexToDec("2123"), "AF", (ByteManipulator.HexToDec("2FFF") - ByteManipulator.HexToDec("2123")) + 1);
                //0x77000
                file.InsertHex(ByteManipulator.HexToDec("77000"), "313830303000B0F7");
                //0x77010
                file.InsertHex(ByteManipulator.HexToDec("77010"), "36340000205941EA");
            } catch(Exception ex) {
                MessageBox.Show("Fatal error has occured generating the file:" + ex.ToString());
            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Binary File";
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.FileName = "bspdata";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;

            if (file.SaveToFile(dialog.FileName))
            {
                MessageBox.Show("File saved successfully.");
            } else {
                MessageBox.Show("File unable to be saved.");
            }
        }
    }
}
