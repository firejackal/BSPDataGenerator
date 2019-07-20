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

            //fill color list.
            this.ColorCombo.Items.Clear();
            this.ColorCombo.Items.Add("");
            this.ColorCombo.Items.Add(new ColorItem("Black/Copper", "CMFF"));
            this.ColorCombo.SelectedIndex = 0;

            this.X1000CheckBox.Checked = false;
            this.AFFFDataCheckBox.Checked = true;
        }

        private void GenerateButton_Click(Object sender, EventArgs e)
        {
            if(this.SerialTextBox.TextLength == 0)
            {
                MessageBox.Show("Please enter a serial number.");
                return;
            }
            if (this.SerialTextBox.TextLength != 16) //63
            {
                MessageBox.Show("The serial number must be 16 characters in length.");
                return;
            }
            //dunno how long the variant is suppose to be. let's say 63 bytes (up to the next character in the file.)
            if (this.VariantCombo.Text.Length > 63)
            {
                MessageBox.Show("The variant name must be between 0 to 63 characters in length.");
                return;
            }
            //dunno how long the color is suppose to be. it's an abbr. let's say 63 bytes (up to the next character in the file.)
            if (this.ColorCombo.Text.Length > 63)
            {
                MessageBox.Show("The color name must be between 0 to 63 characters in length.");
                return;
            }
            string colorID = this.ColorCombo.Text;
            try
            {
                if (this.ColorCombo.SelectedIndex > 0) colorID = ((ColorItem)this.ColorCombo.SelectedItem).ID;
            } catch(Exception ex) {
                MessageBox.Show("Error parsing the color code." + System.Environment.NewLine + ex.Message);
                return;
            }

            ByteManipulator file = new ByteManipulator(PartitionSize);
            
            // insert data
            try
            {
                //0x0: Header
                file.InsertHex(ByteManipulator.HexToDec("0"), "44664D5F0200000005"); 
                //0xC-0x14: Product ID/Serial Number Header
                file.InsertText(ByteManipulator.HexToDec("C"), "productid");
                //0x15-0x1B: null space
                //0x1C-0x5B: Product ID/Serial Number Text (63 characters) //7 characters after header string
                file.InsertText(ByteManipulator.HexToDec("1C"), this.SerialTextBox.Text);
                //0x5C: Product ID/Serial Number Length
                file.InsertByte(ByteManipulator.HexToDec("5C"), Convert.ToByte(this.SerialTextBox.Text.Length));
                //0x5D-0x5F: null space
                //0x60-0x65: Magic
                file.InsertHex(ByteManipulator.HexToDec("60"), "01000000BC01");
                //0x66-0x67: null space
                //0x68-0x6D: Bluetooth MAC Address Header
                file.InsertText(ByteManipulator.HexToDec("68"), "bt_mac");
                //0xBC-0xC1: Magic
                file.InsertHex(ByteManipulator.HexToDec("BC"), "01000000BC01");
                //0xC2-0xC3: null space
                //0xC4-0xCB: WiFi MAC Address Header
                file.InsertText(ByteManipulator.HexToDec("C4"), "wifi_mac");
                //0x118-0x11D: Magic
                file.InsertHex(ByteManipulator.HexToDec("118"), "01000000BC01");
                //0x11E-0x11F: zero space
                //0x120-0x124: Variant Header
                file.InsertText(ByteManipulator.HexToDec("120"), "skuid");
                //0x125-0x12F: zero space
                if (!string.IsNullOrEmpty(this.VariantCombo.Text))
                {
                    //0x130: Variant Text //11 characters after header string
                    file.InsertText(ByteManipulator.HexToDec("130"), this.VariantCombo.Text);
                    //0x170: Variant Length
                    file.InsertByte(ByteManipulator.HexToDec("170"), Convert.ToByte(this.VariantCombo.Text.Length)); //this flag seems to be missing on other devices
                }
                //0x171-0x173: zero space
                //0x174-0x179: Magic
                file.InsertHex(ByteManipulator.HexToDec("174"), "01000000BC01");
                //0x17A-0x17B: zero space
                //0x17C-0x180: Color Header
                file.InsertText(ByteManipulator.HexToDec("17C"), "color");
                if (!string.IsNullOrEmpty(colorID))
                {
                    //0x18C: Color string
                    file.InsertText(ByteManipulator.HexToDec("18C"), colorID);
                    //0x1CC: Color length
                    file.InsertByte(ByteManipulator.HexToDec("1CC"), Convert.ToByte(colorID.Length)); //this flag seems to be missing on other devices
                }
                //0x1D0-0x1D5: Magic
                file.InsertHex(ByteManipulator.HexToDec("1D0"), "01000000BC01");
                //0x1D6-0x1D7: zero space
                //0x1D8 to 0xFFF: Unknown Data #1
                if(this.AFFFDataCheckBox.Checked) file.InsertHex(ByteManipulator.HexToDec("1D8"), "AF", (ByteManipulator.HexToDec("FFF") - ByteManipulator.HexToDec("1D8")) + 1);
                //0x1000: Unknown Data #2: Contains a string 0x00000000 on some devices.
                if(this.X1000CheckBox.Checked) file.InsertText(ByteManipulator.HexToDec("1000"), "0x00000000");
                //0x2000 to 0x2122: Unknown Data #3
                if(this.AFFFDataCheckBox.Checked) file.InsertHex(ByteManipulator.HexToDec("2000"), "FF", (ByteManipulator.HexToDec("2122") - ByteManipulator.HexToDec("2000")) + 1);
                //0x2123 to 0x2FFF: Unknown Data #4
                if(this.AFFFDataCheckBox.Checked) file.InsertHex(ByteManipulator.HexToDec("2123"), "AF", (ByteManipulator.HexToDec("2FFF") - ByteManipulator.HexToDec("2123")) + 1);
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
                //color
                string colorID = ByteManipulator.ReadString(data, ByteManipulator.HexToDec("18C"));
                bool colorFound = false;
                if (!string.IsNullOrEmpty(colorID))
                {
                    //find item in list, if not found set it as text.
                    if (this.ColorCombo.Items.Count > 1) {
                        for(int index = 1; index < this.ColorCombo.Items.Count; index++)
                        {
                            ColorItem color = (ColorItem)this.ColorCombo.Items[index];
                            if(string.Equals(colorID, color.ID, StringComparison.CurrentCultureIgnoreCase))
                            {
                                colorFound = true;
                                this.ColorCombo.SelectedIndex = index;
                                break;
                            }
                        }
                    }
                }
                if (!colorFound) this.ColorCombo.Text = colorID;
                //0x1000 Check Box
                //byte flag1 = ByteManipulator.ReadByte(data, ByteManipulator.HexToDec("170"));
                string x1000value = ByteManipulator.ReadString(data, ByteManipulator.HexToDec("1000"));
                this.X1000CheckBox.Checked = (string.Equals(x1000value, "0x00000000", StringComparison.CurrentCultureIgnoreCase));
                //extra AF and FF data.
                //since we haven't seen any other instances of this, let's just check for the first spot.
                byte firstCheck = ByteManipulator.ReadByte(data, ByteManipulator.HexToDec("1D8"));
                this.AFFFDataCheckBox.Checked = (firstCheck == 175); //0xAF = 175
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to parse source file:" + System.Environment.NewLine + e.Message);
            }
        }
    }

    public class ColorItem
    {
        public string DisplayName = "";
        public string ID = "";

        public ColorItem() { }

        public ColorItem(string displayName, string ID) { this.DisplayName = displayName; this.ID = ID; }

        public override String ToString() { return this.DisplayName; }
    }
}
