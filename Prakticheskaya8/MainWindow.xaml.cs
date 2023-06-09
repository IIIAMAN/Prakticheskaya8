using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibrariMain;
using ThemsLib;

namespace Prakticheskaya8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            jpj();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SerDeser.MySerialize(TextPole.Text);
            TextPole.Clear();
        }

        void jpj()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (File.Exists(desktop + "\\MyFile.json"))
            {
                TextPole.Text = SerDeser.MyDeserialize<string>();
            }
            else
            {
                File.AppendAllText(desktop + "\\MyFile.json", "'Заполните файл'");
                jpj();
            }
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            CodeThemes.Theme = "BlueColour";
        }

        private void PersikButton_Click(object sender, RoutedEventArgs e)
        {
            CodeThemes.Theme = "PersicColour";
        }
    }
}
