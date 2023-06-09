using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LibrariMain;
using ThemsLib;

namespace Prakticheskaya8
{
    public partial class App : Application
    {
       public App()
        {
            InitializeComponent();

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (File.Exists($"{desktop}\\theme.txt"))
            {
                CodeThemes.Theme = File.ReadAllText($"{desktop}\\theme.txt");
            }
        }
    }
}
