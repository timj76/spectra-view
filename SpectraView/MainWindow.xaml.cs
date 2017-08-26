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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // OpenFileDialog openFileDialog;
        string Bildname = @"";
        double höhe = 0;
        double breite = 0;

        public MainWindow()
        {

            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                Bildname = openFileDialog.FileName;
                hauptImage.Source = new BitmapImage(new Uri(Bildname));


        }

        private void slider_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            double i = slider.Value;
            double j = slider.PreviewMouseWheel(ManipulationDeltaEventArgs )
            höhe = hauptImage.Height;
            breite = hauptImage.Width;

            hauptImage.Height = höhe + i;
            hauptImage.Width = breite + i;


        }

        private void slider_MouseWheel_1(object sender, MouseWheelEventArgs e)
        {

        }
    }

  
}
        
    
