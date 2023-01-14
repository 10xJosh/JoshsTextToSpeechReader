using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JoshsTextToSpeechReader.MenuItems
{
    internal class MenuMethods
    {

        public string GetImportedFile(string path)
        {
            try
            {
                string fileContents = File.ReadAllText(path);
                return fileContents;
            }
            catch(Exception ex)
            {
                return $"{ex}";
            }
        }

        public void GetAbout()
        {
            MessageBox.Show("Program created by Josh Davis \nhttps://github.com/10xJosh ", 
                "About", MessageBoxButton.OK, MessageBoxImage.None);
        }

    }
}
