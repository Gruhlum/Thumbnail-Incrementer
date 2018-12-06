using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thumbnail__
{
    public class Thumbnail
    {
        //TODO find better solution
        public const float ALIGN_MULTI = 0.72757f;

        public string name;
        public DateTime lastUsed = DateTime.Now;
        public string imagePath;
        public AnchorStyles anchor = AnchorStyles.Left;
        public int increment = 1;
        public int xPos = 50;
        public int yPos = 0;

        public PointF Position
        {
            get
            {
                return new PointF(GetXPosition(), defaultImage.Height - GetYPosition());
            }
        }
        public Font Font
        {
            get
            {
                return new Font(FontName, FontSize);
            }
        }

        public string FontName
        {
            get
            {
                return fontName;
            }
            set
            {
                fontName = value;
            }
        }
        string fontName = "Arial";

        public int FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
            }
        }
        int fontSize = 300;

        public bool IsBold
        {
            get
            {
                return isBold;
            }
            set
            {
                isBold = value;
            }
        }
        bool isBold;

        public bool IsCursive
        {
            get
            {
                return isCursive;
            }
            set
            {
                isCursive = value;
            }
        }
        bool isCursive;

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
            }
        }
        int borderSize;

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
            }
        }
        Color borderColor = Color.Black;

        public Color FontColor
        {
            get
            {
                return fontColor;
            }
            set
            {
                fontColor = value;
            }
        }
        Color fontColor = Color.White;

        public Image image;
        public Image defaultImage;

        public Thumbnail(string pathName)
        {          
            if (pathName != null)
            {
                imagePath = pathName;
                defaultImage = Image.FromFile(pathName);
                yPos = defaultImage.Height;
                lastUsed = DateTime.Now;
            }                      
        }
                       
        public void Save()
        {
            string[] values = new string[17];
            values[0] = name;
            values[1] = imagePath;
            values[2] = anchor.ToString();
            values[3] = increment.ToString();
            values[4] = xPos.ToString();
            values[5] = yPos.ToString();
            values[6] = lastUsed.ToString();
            values[7] = FontName;
            values[8] = FontSize.ToString();
            values[9] = IsBold.ToString();
            values[10] = IsCursive.ToString();
            values[11] = FontColor.ToArgb().ToString();
            values[12] = BorderSize.ToString();
            values[13] = BorderColor.ToArgb().ToString();

            DataHelper.SaveData(values, name);
        }
        public void Load(string fileName)
        {
            string[] values = DataHelper.LoadData(fileName);

            name = values[0];
            imagePath = values[1];
            if (File.Exists(imagePath))
            {
                defaultImage = Image.FromFile(imagePath);
            }
            else defaultImage = Properties.Resources.MissingFile;
            anchor = ConvertToAnchor(values[2]);
            increment = Convert.ToInt32(values[3]);
            xPos = Convert.ToInt16(values[4]);
            yPos = Convert.ToInt16(values[5]);
            lastUsed = Convert.ToDateTime(values[6]);
            FontName = values[7];
            FontSize = Convert.ToInt16(values[8]);
            IsBold = Convert.ToBoolean(values[9]);
            IsCursive = Convert.ToBoolean(values[10]);
            FontColor = Color.FromArgb(Convert.ToInt32(values[11]));
            BorderSize = Convert.ToInt16(values[12]);
            BorderColor = Color.FromArgb(Convert.ToInt32(values[13]));
        }

        private AnchorStyles ConvertToAnchor(string name)
        {
            if (name == AnchorStyles.Left.ToString())
                return AnchorStyles.Left;
            if (name == AnchorStyles.Right.ToString())
                return AnchorStyles.Right;
            else return AnchorStyles.None;
        }

        private float GetXPosition()
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF size = g.MeasureString(increment.ToString(), Font);

                if (anchor == AnchorStyles.Right)
                {
                    return xPos - size.Width * ALIGN_MULTI;
                }
                else if (anchor == AnchorStyles.None)
                {
                    return xPos - size.Width / 2 * ALIGN_MULTI;
                }
                return xPos;
            }                     
        }
        private float GetYPosition()
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(1, 1)))
            {
                SizeF size = g.MeasureString(increment.ToString(), Font);
                return yPos;
            }           
        }
    }
}
