using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thumbnail__
{
    public partial class MainControl : Form
    {
        public Thumbnail selectedThumbnail;
        public List<Thumbnail> savedThumbnails = new List<Thumbnail>();
        private List<PictureBox> savedBoxes = new List<PictureBox>();

        private bool allowBuild = true;

        public MainControl()
        {
            InitializeComponent();
            DataHelper.ImageFolderChanged += OnImageFolder_Changed;
            AddPictureBoxes();
            LoadConfig();
            LoadFonts();
            LoadThumbnails();
            if (savedThumbnails.Count != 0)
            {
                DisplaySelectedThumbnail(savedThumbnails.First());
            }
        }

        private void AddPictureBoxes()
        {
            savedBoxes.Add(PBSaved1);
            savedBoxes.Add(PBSaved2);
            savedBoxes.Add(PBSaved3);
            savedBoxes.Add(PBSaved4);
        }
        private void LoadConfig()
        {
            string[] values = DataHelper.LoadData("Config");
            if (values != null && values.Count() >= 1)
            {
                DataHelper.ImageFolder = values[0];
                if (values.Count() >= 2)
                {
                    TBEnding.Text = values[1];
                }                
            }           
        }
        private void LoadThumbnails()
        {
            string[] filePaths = DataHelper.GetAllFiles();
            if (filePaths == null)
            {
                return;
            }
            foreach (var path in filePaths)
            {
                string fileName = DataHelper.GetFileName(path);
                if (fileName != "Config")
                {
                    Thumbnail thumbnail = new Thumbnail(null);
                    thumbnail.Load(fileName);
                    savedThumbnails.Add(thumbnail);
                }
            }
            DisplaySavedThumbnails();
        }
        private void LoadFonts()
        {
            using (InstalledFontCollection fontsCollection = new InstalledFontCollection())
            {
                FontFamily[] fontFamilies = fontsCollection.Families;
                foreach (FontFamily font in fontFamilies)
                {
                    if (font.Name != "")
                        CBFonts.Items.Add(font.Name);
                }
            }
            CBFonts.SelectedIndex = 0;
        }

        private Image BuildImage(Thumbnail thumb)
        {
            if (thumb == null || thumb.defaultImage == null || allowBuild == false)
            {
                return null;
            }
            if (thumb.image != null)
            {
                thumb.image.Dispose();
            }
            thumb.image = thumb.defaultImage.Clone() as Image;
            Graphics g = Graphics.FromImage(thumb.image);
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            GraphicsPath outlinePath = new GraphicsPath();
            outlinePath.AddString(thumb.increment.ToString(), 
                selectedThumbnail.Font.FontFamily, 0, thumb.FontSize, thumb.Position, StringFormat.GenericTypographic);

            g.FillPath(new SolidBrush(selectedThumbnail.FontColor), outlinePath);
            if (thumb.BorderSize > 0)
            {
                g.DrawPath(new Pen(thumb.BorderColor, thumb.BorderSize), outlinePath);
            }          
            outlinePath.Dispose();
            g.Dispose();
            return thumb.image;
        }
        private void DisplaySavedThumbnails()
        {
            int i = 0;
            savedThumbnails.Sort((y, x) => x.lastUsed.CompareTo(y.lastUsed));
            foreach (var box in savedBoxes)
            {
                if (savedThumbnails.Count > i)
                {
                    box.Image = savedThumbnails[i].defaultImage;
                    i++;
                }
            }
        }                       
        private void DisplaySelectedThumbnail(Thumbnail thumbnail)
        {
            allowBuild = false;
            selectedThumbnail = thumbnail;
            NumericUDIncrement.Value = thumbnail.increment;
            NumericUDFontSize.Value = thumbnail.FontSize;
            NumericUDBorderSize.Value = thumbnail.BorderSize;
            NumericUDPositionX.Value = thumbnail.xPos;
            NumericUDPositionY.Value = thumbnail.yPos;
            CBFonts.Text = thumbnail.FontName;
            LabelName.Text = thumbnail.name;
            PBSelect.Image = BuildImage(thumbnail);
            BtnFontColor.BackColor = thumbnail.FontColor;
            BtnBorderColor.BackColor = thumbnail.BorderColor;
            allowBuild = true;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }

        private SizeF GetTextSize(string text, Font font)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                return g.MeasureString(text, font);
            }                      
        }

        private void OnImageFolder_Changed()
        {
            TBOutputPath.Text = DataHelper.ImageFolder;
            ToolTip1.SetToolTip(TBOutputPath, TBOutputPath.Text);
            BtnCreate.Enabled = true;
        }
        private void MainControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in savedThumbnails)
            {
                item.Save();
            }
            string[] config = new string[2];
            config[0] = DataHelper.ImageFolder;
            config[1] = TBEnding.Text;
            DataHelper.SaveData(config, "Config");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png"
            };
            DialogResult d = op.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (savedThumbnails.Any(x => x.imagePath == op.FileName))
                {
                    Thumbnail tempThumbnail = savedThumbnails.Find(x => x.imagePath == op.FileName);
                    tempThumbnail.lastUsed = DateTime.Now;
                    DisplaySelectedThumbnail(tempThumbnail);
                    DisplaySavedThumbnails();
                    return;
                }
                Thumbnail thumbnail = new Thumbnail(op.FileName)
                {
                    name = DataHelper.GetFileName(op.FileName)
                };
                DisplaySelectedThumbnail(thumbnail);
                savedThumbnails.Add(thumbnail);
                DisplaySavedThumbnails();
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (selectedThumbnail.anchor == AnchorStyles.Right)
            {
                selectedThumbnail.anchor = AnchorStyles.Left;
                NumericUDPositionX.Value -= (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width * Thumbnail.ALIGN_MULTI);
            }
            else if (selectedThumbnail.anchor == AnchorStyles.None)
            {
                selectedThumbnail.anchor = AnchorStyles.Left;
                NumericUDPositionX.Value -= (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2 * Thumbnail.ALIGN_MULTI);
            }          
        }     
        private void BtnCenter_Click(object sender, EventArgs e)
        {
            if (selectedThumbnail.anchor == AnchorStyles.Right)
            {
                selectedThumbnail.anchor = AnchorStyles.None;
                NumericUDPositionX.Value -= (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2 * Thumbnail.ALIGN_MULTI);
            }
            else if (selectedThumbnail.anchor == AnchorStyles.Left)
            {
                selectedThumbnail.anchor = AnchorStyles.None;
                NumericUDPositionX.Value += (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2 * Thumbnail.ALIGN_MULTI);
            }            
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void BtnRight_Click(object sender, EventArgs e)
        {            
            if (selectedThumbnail.anchor == AnchorStyles.Left)
            {
                selectedThumbnail.anchor = AnchorStyles.Right;
                NumericUDPositionX.Value += (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width * Thumbnail.ALIGN_MULTI);
            }
            else if (selectedThumbnail.anchor == AnchorStyles.None)
            {
                selectedThumbnail.anchor = AnchorStyles.Right;
                NumericUDPositionX.Value += (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2 * Thumbnail.ALIGN_MULTI);
            }
            
            PBSelect.Image = BuildImage(selectedThumbnail);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {           
            DataHelper.SaveImage(selectedThumbnail.image, selectedThumbnail.name + "_" + selectedThumbnail.increment, TBEnding.Text);
            NumericUDIncrement.Value++;
        }      
        private void BtnChangeOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DataHelper.ImageFolder = fbd.SelectedPath;
                }
            }
        }
        private void BtnFontColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                BtnFontColor.BackColor = colorDialog1.Color;
                selectedThumbnail.FontColor = colorDialog1.Color;
                PBSelect.Image = BuildImage(selectedThumbnail);
            }
        }
        private void BtnBorderColor_Click(object sender, EventArgs e)
        {
            DialogResult d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                BtnBorderColor.BackColor = colorDialog1.Color;
                selectedThumbnail.BorderColor = colorDialog1.Color;
                PBSelect.Image = BuildImage(selectedThumbnail);
            }
        }

        private void PBSavedThumbnails_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb.Image == null)
            {
                return;
            }
            Thumbnail thumbnail = savedThumbnails.Find(x => x.defaultImage == pb.Image);
            thumbnail.lastUsed = DateTime.Now;
            DisplaySelectedThumbnail(thumbnail);
        }

        private void NumericUDFontSize_ValueChanged(object sender, EventArgs e)
        {
            selectedThumbnail.FontSize = (int)NumericUDFontSize.Value;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void NumericUDIncrement_ValueChanged(object sender, EventArgs e)
        {
            selectedThumbnail.increment = (int)NumericUDIncrement.Value;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void NumericUDPositionX_ValueChanged(object sender, EventArgs e)
        {
            selectedThumbnail.xPos = (int)NumericUDPositionX.Value;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void NumericUDPositionY_ValueChanged(object sender, EventArgs e)
        {
            selectedThumbnail.yPos = (int)NumericUDPositionY.Value;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void NumericUDBorderSize_ValueChanged(object sender, EventArgs e)
        {
            selectedThumbnail.BorderSize = (int)NumericUDBorderSize.Value;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }

        private void CBFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectedThumbnail == null)
            {
                return;
            }
            selectedThumbnail.FontName = CBFonts.Text;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }

        private void LabelName_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Title = "Select a picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png"
            };
            DialogResult d = op.ShowDialog();
            if (d == DialogResult.OK)
            {
                DataHelper.DeleteFile(selectedThumbnail.name);
                selectedThumbnail.name = DataHelper.GetFileName(op.FileName);
                selectedThumbnail.imagePath = op.FileName;
                selectedThumbnail.defaultImage = Image.FromFile(op.FileName);
                DisplaySelectedThumbnail(selectedThumbnail);
                DisplaySavedThumbnails();
            }
        }
    }
}