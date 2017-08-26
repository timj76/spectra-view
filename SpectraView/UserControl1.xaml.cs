using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace SpectraView
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private OpenFileDialog openFileDialog;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Bild öffnen";
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = true;
                string dateiname = @"";
                openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.FilterIndex = 5; // Hier: Alle Bilddateien


                if (openFileDialog.ShowDialog() == true)
                    dateiname = openFileDialog.FileName; 
                    image.Source = new BitmapImage(new Uri(dateiname));


            }
        }
    }
}
