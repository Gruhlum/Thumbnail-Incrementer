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
        public int lastUsed;
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
        string fontName = "Ariel";

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

        public void Save()
        {
            string[] values = new string[10];
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

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\");
            }
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\" + name + @".txt", values);
        }
        public void Load(string fileName)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\" + fileName + @".txt"))
            {
                string[] values = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\" + fileName + @".txt");

                name = values[0];
                path = values[1];
                anchor = ConvertToAnchor(values[2]);
                increment = Convert.ToInt16(values[3]);
                xPos = Convert.ToInt16(values[4]);
                yPos = Convert.ToInt16(values[5]);
                FontName = values[6];
                FontSize = Convert.ToInt16(values[7]);
                IsBold = Convert.ToBoolean(values[8]);
                IsCursive = Convert.ToBoolean(values[9]);
                lastUsed = Convert.ToInt16(values[10]);
            }
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

        public static void LoadThumbnails()
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\"))
            {
                return;
            }
            string[] filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"LastThumbnails\");

            foreach (var path in filePaths)
            {
                Thumbnail thumbnail = new Thumbnail();
                thumbnail.Load(GetFileName(path));
            }
        }
        public static string GetFileName(string path)
        {
            int lastIndex = path.LastIndexOf('\\') + 1;
            return path.Substring(lastIndex, (path.Length - lastIndex) - ".txt".Length);
        }
    }
}
