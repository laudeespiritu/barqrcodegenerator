using System;
using BarcodeLib;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BarQRCodeGenerator
{
    public partial class Generator : Form
    {
        private Barcode barcode = new Barcode();
        private readonly string _statusGenerate = "Generating: ";
        private readonly string _statusEncode = "Encoding Type: ";
        private readonly string _statusECC = "ECC Level: ";

        public Generator()
        {
            InitializeComponent();
        }

        #region Methods
        private void SetFormStatus()
        {
            tsslGenerateType.Text = _statusGenerate;

            if (tabMenu.SelectedIndex == 0)
            {
                tsslGenerateType.Text += "Barcode";
                tsslEncoding.Text = _statusEncode + ddlEncoding.Text;
                tsslEncoding.Visible = true;
                tsslECCLevel.Visible = false;
            }
            else
            {
                tsslGenerateType.Text += "QR Code";
                tsslECCLevel.Text = _statusECC + ddlECCLevel.Text;
                tsslEncoding.Visible = false;
                tsslECCLevel.Visible = true;
            }
        }

        private void GenerateBarcode()
        {
            errorProvider1.Clear();
            var W = Convert.ToInt32(txtWidth.Text.Trim());
            var H = Convert.ToInt32(txtHeight.Text.Trim());
            var fgColor = btnFGColor.BackColor;
            var bgColor = btnBGColor.BackColor;
            barcode.Alignment = AlignmentPositions.CENTER;

            //Barcode Alignment
            switch (ddlAlignment.SelectedItem.ToString().Trim().ToUpper())
            {
                case "LEFT": barcode.Alignment = AlignmentPositions.LEFT; break;
                case "RIGHT": barcode.Alignment = AlignmentPositions.RIGHT; break;
                default: barcode.Alignment = AlignmentPositions.CENTER; break;
            }

            TYPE type = TYPE.UNSPECIFIED;
            switch (ddlEncoding.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = TYPE.UPCA; break;
                case "UPC-E": type = TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = TYPE.EAN13; break;
                case "JAN-13": type = TYPE.JAN13; break;
                case "EAN-8": type = TYPE.EAN8; break;
                case "ITF-14": type = TYPE.ITF14; break;
                case "Codabar": type = TYPE.Codabar; break;
                case "PostNet": type = TYPE.PostNet; break;
                case "Bookland/ISBN": type = TYPE.BOOKLAND; break;
                case "Code 11": type = TYPE.CODE11; break;
                case "Code 39": type = TYPE.CODE39; break;
                case "Code 39 Extended": type = TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = TYPE.CODE39_Mod43; break;
                case "Code 93": type = TYPE.CODE93; break;
                case "LOGMARS": type = TYPE.LOGMARS; break;
                case "MSI": type = TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = TYPE.Interleaved2of5; break;
                case "Interleaved 2 of 5 Mod 10": type = TYPE.Interleaved2of5_Mod10; break;
                case "Standard 2 of 5": type = TYPE.Standard2of5; break;
                case "Standard 2 of 5 Mod 10": type = TYPE.Standard2of5_Mod10; break;
                case "Code 128": type = TYPE.CODE128; break;
                case "Code 128-A": type = TYPE.CODE128A; break;
                case "Code 128-B": type = TYPE.CODE128B; break;
                case "Code 128-C": type = TYPE.CODE128C; break;
                case "Telepen": type = TYPE.TELEPEN; break;
                case "FIM": type = TYPE.FIM; break;
                case "Pharmacode": type = TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }

            try
            {
                if (type != TYPE.UNSPECIFIED)
                {
                    try
                    {
                        barcode.BarWidth = txtBarWidth.Text.Trim().Length < 1 ? null : (int?)Convert.ToInt32(txtBarWidth.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse BarWidth: " + ex.Message, ex);
                    }
                    try
                    {
                        barcode.AspectRatio = txtAspectRatio.Text.Trim().Length < 1 ? null : (double?)Convert.ToDouble(txtAspectRatio.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Unable to parse AspectRatio: " + ex.Message, ex);
                    }

                    barcode.IncludeLabel = this.chkAddLabel.Checked;
                    barcode.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.ddlRotate.SelectedItem.ToString(), true);

                    if (!string.IsNullOrEmpty(txtBarcodeLabel.Text.Trim()))
                        barcode.AlternateLabel = txtBarcodeLabel.Text.Trim();
                    else
                        barcode.AlternateLabel = txtData.Text.Trim();

                    //Barcode Label Alignment
                    if (chkAddLabel.Checked)
                    switch (ddlLabelPosition.SelectedItem.ToString().Trim().ToUpper())
                    {
                        case "BOTTOMLEFT": barcode.LabelPosition = LabelPositions.BOTTOMLEFT; break;
                        case "BOTTOMRIGHT": barcode.LabelPosition = LabelPositions.BOTTOMRIGHT; break;
                        case "TOPCENTER": barcode.LabelPosition = LabelPositions.TOPCENTER; break;
                        case "TOPLEFT": barcode.LabelPosition = LabelPositions.TOPLEFT; break;
                        case "TOPRIGHT": barcode.LabelPosition = LabelPositions.TOPRIGHT; break;
                        default: barcode.LabelPosition = LabelPositions.BOTTOMCENTER; break;
                    }

                    //Generate Barcode
                    gbPreview.BackgroundImage = barcode.Encode(type, txtData.Text.Trim(), fgColor, bgColor, W, H);

                    // Read dynamically calculated Width/Height because the user is interested.
                    if (barcode.BarWidth.HasValue)
                        txtWidth.Text = barcode.Width.ToString();
                    if (barcode.AspectRatio.HasValue)
                        txtHeight.Text = barcode.Height.ToString();
                }

                //Preview generated Barcode
                gbPreview.Location = new Point((gbPreview.Location.X + gbPreview.Width / 2) - barcode.Width / 2, (gbPreview.Location.Y + gbPreview.Height / 2) - gbPreview.Height / 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateQRCode()
        {
            var level = ddlECCLevel.SelectedItem.ToString();
            var fgColor = btnFGColor.BackColor;
            var bgColor = btnBGColor.BackColor;

            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (var qrGenerator = new QRCodeGenerator())
            {
                using (var qrCodeData = qrGenerator.CreateQrCode(txtData.Text.Trim(), eccLevel))
                {
                    using (var qrCode = new QRCode(qrCodeData))
                    {
                        gbPreview.BackgroundImage = qrCode.GetGraphic(20, fgColor, bgColor, GetIconBitmap(), (int)numIconSize.Value);
                    }
                }
            }
        }

        private void SaveImageAs()
        {
            if (gbPreview.BackgroundImage == null)
            {
                MessageBox.Show("Generate a value first!");
                txtData.Focus();
            }
            else
            {
                //Open SaveFileDialog for users to save the Image
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Bitmap Image|*.bmp|PNG Image|*.png|JPeg Image|*.jpg|Gif Image|*.gif",
                    Title = "Save Generated Image As",
                    FileName = txtData.Text.Trim()
                };
                saveFileDialog.ShowDialog();

                //Check if filename is not EMPTY
                if (saveFileDialog.FileName != string.Empty)
                {
                    //Saves the Image via FileStream created by the OpenFile method.
                    using (var fs = (FileStream)saveFileDialog.OpenFile())
                    {
                        // Saves the Image in the appropriate ImageFormat based upon the
                        // File type selected in the dialog box.
                        // NOTE that the FilterIndex property is one-based.

                        ImageFormat imageFormat = null;
                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                imageFormat = ImageFormat.Bmp;
                                break;
                            case 2:
                                imageFormat = ImageFormat.Png;
                                break;
                            case 3:
                                imageFormat = ImageFormat.Jpeg;
                                break;
                            case 4:
                                imageFormat = ImageFormat.Gif;
                                break;
                            default:
                                throw new NotSupportedException("File extension is not supported");
                        }

                        gbPreview.BackgroundImage.Save(fs, imageFormat);
                        fs.Close();
                    }
                }
            }
        }

        private void UploadIcon()
        {
            var openFileDlg = new OpenFileDialog
            {
                Title = "Select icon",
                Multiselect = false,
                CheckFileExists = true
            };

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtIconPath.Text = openFileDlg.FileName;
                if (numIconSize.Value == 0)
                {
                    numIconSize.Value = 15;
                }
            }
            else
            {
                txtIconPath.Text = string.Empty;
            }
        }

        private Bitmap GetIconBitmap()
        {
            Bitmap img = null;
            if (txtIconPath.Text.Length > 0)
            {
                try
                {
                    img = new Bitmap(txtIconPath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return img;
        }

        private Color ColorPicker()
        {
            var colorChoice = new Color();

            using (var colorDialog = new ColorDialog())
            {
                colorDialog.AnyColor = true;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    colorChoice = colorDialog.Color;
            }

            return colorChoice;
        }
        #endregion

        #region Events
        private void Generator_Load(object sender, EventArgs e)
        {
            ddlEncoding.SelectedIndex = 0;
            ddlAlignment.SelectedIndex = 0;
            ddlLabelPosition.SelectedIndex = 0;
            ddlECCLevel.SelectedIndex = 0;
            ddlRotate.DataSource = Enum.GetNames(typeof(RotateFlipType));

            var i = ddlRotate.Items.IndexOf("RotateNoneFlipNone") < 0 ? 0 : ddlRotate.Items.IndexOf("RotateNoneFlipNone");
            ddlRotate.SelectedIndex = i;

            SetFormStatus();
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormStatus();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var menuIndex = tabMenu.SelectedIndex;
            if (menuIndex == 0)
                GenerateBarcode();
            else
                GenerateQRCode();
        }

        private void ddlEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsslEncoding.Text = _statusEncode + ddlEncoding.Text;
        }

        private void ddlECCLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsslECCLevel.Text = _statusECC + ddlECCLevel.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImageAs();
        }

        private void btnUploadIcon_Click(object sender, EventArgs e)
        {
            UploadIcon();
        }

        private void btnFGColor_Click(object sender, EventArgs e)
        {
            var btnSender = (Button)sender;
            btnSender.BackColor = ColorPicker();
        }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            var btnSender = (Button)sender;
            btnSender.BackColor = ColorPicker();
        }

        private void chkAddLabel_CheckedChanged(object sender, EventArgs e)
        {
            var chkSender = (CheckBox)sender;
            if (chkSender.Checked)
            {
                txtBarcodeLabel.Text = txtData.Text.Trim();
                txtBarcodeLabel.Focus();
            }
            else
                txtBarcodeLabel.Text = string.Empty;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if (chkAddLabel.Checked)
                chkAddLabel.Checked = false;
        }
        #endregion
    }
}
