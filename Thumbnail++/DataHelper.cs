using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thumbnail__
{
    public class DataHelper
    {
        const string mainFolder = @"Saved\";
        static public string ImageFolder
        {
            get
            {
                return imageFolder;
            }
            set
            {
                imageFolder = value;
                if (ImageFolderChanged != null)
                {
                    ImageFolderChanged();
                }                              
            }
        }
        private static string imageFolder;

        static public Action ImageFolderChanged;        

        public static string[] GetAllFiles(string folder = mainFolder)
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + folder))
            {
                Debug.WriteLine(AppDomain.CurrentDomain.BaseDirectory + folder + " is empty");
                return null;
            }
            return Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + mainFolder);
            
        }
        public static void SaveImage(Image image, string name)
        {
            if (!Directory.Exists(ImageFolder))
            {
                Directory.CreateDirectory(ImageFolder);
            }
            image.Save(ImageFolder + @"\" + name + ".png");
        }

        public static void SaveData(string[] values, string name, string folder = mainFolder)
        {           
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + folder))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + folder);
            }
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + folder + name + @".txt", values);
        }
        public static string[] LoadData(string fileName, string folder = mainFolder)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + folder + fileName + @".txt"))
            {
                return File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + folder + fileName + @".txt");
            }
            else return null;
        }

        public static string GetFileName(string path)
        {
            int lastIndex = path.LastIndexOf('\\') + 1;
            return path.Substring(lastIndex, (path.Length - lastIndex) - ".txt".Length);
        }
    }
}
