using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        //public AnchorStyles PictureAnchor
        //{
        //    get
        //    {
        //        return pictureAnchor;
        //    }
        //    set
        //    {
        //        pictureAnchor = value;
        //        if (pictureAnchor == AnchorStyles.Left)
        //        {
        //            BtnLeft.Enabled = false;
        //            BtnCenter.Enabled = true;
        //            BtnRight.Enabled = true;
        //        }
        //        if (pictureAnchor == AnchorStyles.None)
        //        {
        //            BtnLeft.Enabled = true;
        //            BtnCenter.Enabled = false;
        //            BtnRight.Enabled = true;
        //        }
        //        if (pictureAnchor == AnchorStyles.Right)
        //        {
        //            BtnLeft.Enabled = true;
        //            BtnCenter.Enabled = true;
        //            BtnRight.Enabled = false;
        //        }
        //    }
        //}
        //AnchorStyles pictureAnchor;

        public MainControl()
        {
            InitializeComponent();
            DataHelper.ImageFolderChanged += OnImageFolder_Changed;
            AddPictureBoxes();
            LoadFonts();
            LoadThumbnails();
            if (savedThumbnails.Count != 0)
            {
                DisplaySelectedThumbnail(savedThumbnails.First());
            }
        }
        private void OnImageFolder_Changed()
        {
            TBOutputPath.Text = DataHelper.ImageFolder;
            ToolTip1.SetToolTip(TBOutputPath, TBOutputPath.Text);
            BtnCreate.Enabled = true;
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
                Thumbnail thumbnail = new Thumbnail(path);
                thumbnail.Load(DataHelper.GetFileName(path));
                savedThumbnails.Add(thumbnail);
            }
            DisplaySavedThumbnails();
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
        private void AddPictureBoxes()
        {
            savedBoxes.Add(PBSaved1);
            savedBoxes.Add(PBSaved2);
            savedBoxes.Add(PBSaved3);
            savedBoxes.Add(PBSaved4);
        }
        
        private void DisplaySelectedThumbnail(Thumbnail thumbnail)
        {
            selectedThumbnail = thumbnail;
            NumericUDIncrement.Value = thumbnail.increment;
            NumericUDFontSize.Value = thumbnail.FontSize;
            NumericUDPositionX.Value = thumbnail.xPos;
            NumericUDPositionY.Value = thumbnail.yPos;
            CBFonts.Text = thumbnail.FontName;
            LabelName.Text = thumbnail.name;
            PBSelect.Image = BuildImage(thumbnail);
        }
        private SizeF GetTextSize(string text, Font font)
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                return g.MeasureString(text, font);
            }                      
        }
        private Image BuildImage(Thumbnail thumb)
        {
            if (thumb.defaultImage == null)
            {
                return null;
            }
            if (thumb.image != null)
            {
                thumb.image.Dispose();
            }
            
            thumb.image = thumb.defaultImage.Clone() as Image;
            Graphics g = Graphics.FromImage(thumb.image);            
            g.DrawString(thumb.increment.ToString(), thumb.Font, Brushes.White, thumb.Position);
            g.Dispose();
            return thumb.image;
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            DialogResult d = op.ShowDialog();
            if (d == DialogResult.OK)
            {
                if (savedThumbnails.Any(x => x.name == op.FileName))
                {
                    DisplaySelectedThumbnail(savedThumbnails.Find(x => x.name == op.FileName));
                    return;
                }
                Thumbnail thumbnail = new Thumbnail(op.FileName);
                thumbnail.name = DataHelper.GetFileName(op.FileName);
                thumbnail.defaultImage = Image.FromFile(op.FileName);
                DisplaySelectedThumbnail(thumbnail);
                savedThumbnails.Add(thumbnail);
                DisplaySavedThumbnails();
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            DataHelper.SaveImage(selectedThumbnail.image, selectedThumbnail.name + selectedThumbnail.increment);

            NumericUDIncrement.Value++;
        }      
        private void BtnRight_Click(object sender, EventArgs e)
        {            
            if (selectedThumbnail.anchor == AnchorStyles.Left)
            {
                NumericUDPositionX.Value += (decimal)GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width;
            }
            else if (selectedThumbnail.anchor == AnchorStyles.None)
            {
                NumericUDPositionX.Value += (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2);
            }
            selectedThumbnail.anchor = AnchorStyles.Right;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }
        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (selectedThumbnail.anchor == AnchorStyles.Right)
            {
                NumericUDPositionX.Value -= (decimal)GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width;
            }
            else if (selectedThumbnail.anchor == AnchorStyles.None)
            {
                NumericUDPositionX.Value -= (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2);
            }
            selectedThumbnail.anchor = AnchorStyles.Left;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }     
        private void BtnCenter_Click(object sender, EventArgs e)
        {
            if (selectedThumbnail.anchor == AnchorStyles.Right)
            {
                NumericUDPositionX.Value -= (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2);
            }
            else if (selectedThumbnail.anchor == AnchorStyles.Left)
            {
                NumericUDPositionX.Value += (decimal)(GetTextSize(NumericUDIncrement.Value.ToString(), selectedThumbnail.Font).Width / 2);
            }
            selectedThumbnail.anchor = AnchorStyles.None;
            PBSelect.Image = BuildImage(selectedThumbnail);
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

        private void CBFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectedThumbnail == null)
            {
                return;
            }
            selectedThumbnail.FontName = CBFonts.Text;
            PBSelect.Image = BuildImage(selectedThumbnail);
        }

        private void PBSaved_Click(object sender, EventArgs e)
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

        private void MainControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in savedThumbnails)
            {
                item.Save();
            }
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
    }

    /*
     * TO DO
     * - Font Selection
     * - Save/Load
     * -- Images
     * -- Font(size, color, position)
     * -- Increment
     * - Auto Update when changing property
     * - Save created thumbnail
    */
}
