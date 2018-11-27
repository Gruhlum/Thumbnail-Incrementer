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
        public string name;
        public DateTime lastUsed = DateTime.Now;
        public string path;
        public AnchorStyles anchor = AnchorStyles.Left;
        public int increment = 0;
        public int xPos = 0;
        public int yPos = 0;

        public PointF Position
        {
            get
            {
                return new PointF(GetXPosition(), yPos);
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
        int fontSize = 400;

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

        public Image image;
        public Image defaultImage;

        public Thumbnail(string pathName)
        {
            path = pathName;
        }
            
           
        public void Save()
        {
            string[] values = new string[11];
            values[0] = name;
            values[1] = path;
            values[2] = anchor.ToString();
            values[3] = increment.ToString();
            values[4] = xPos.ToString();
            values[5] = yPos.ToString();
            values[6] = FontName;
            values[7] = FontSize.ToString();
            values[8] = IsBold.ToString();
            values[9] = IsCursive.ToString();
            values[10] = lastUsed.ToString();
            DataHelper.SaveData(values, name);
        }

        public void Load(string fileName)
        {
            string[] values = DataHelper.LoadData(fileName);

            name = values[0];
            path = values[1];
            defaultImage = Image.FromFile(path);
            anchor = ConvertToAnchor(values[2]);
            increment = Convert.ToInt16(values[3]);
            xPos = Convert.ToInt16(values[4]);
            yPos = Convert.ToInt16(values[5]);
            FontName = values[6];
            FontSize = Convert.ToInt16(values[7]);
            IsBold = Convert.ToBoolean(values[8]);
            IsCursive = Convert.ToBoolean(values[9]);
            lastUsed = Convert.ToDateTime(values[10]);
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
            float x = 0;

            Graphics g = Graphics.FromImage(new Bitmap(1, 1));
            SizeF size = g.MeasureString(increment.ToString(), Font);

            if (anchor == AnchorStyles.Right)
            {
                x = xPos - size.Width;
            }
            else if (anchor == AnchorStyles.None)
            {
                x = xPos - size.Width / 2;
            }
            else x = xPos;

            return x;
        }

        
    }
}
