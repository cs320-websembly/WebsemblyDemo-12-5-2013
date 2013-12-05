using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;
using System.IO;

namespace SurfaceApplication1
{
    /// <summary>
    /// Interaction logic for TagVisualization1.xaml
    /// </summary>
    public partial class TagVisualization1 : TagVisualization
    {
        public TagVisualization1()
        {   
            InitializeComponent();
          /*  Uri uri = new Uri ("Pictures/HoltonPool.jpg", UriKind.Relative);
            BitmapImage bitmap = new BitmapImage (uri);
            Image image = new Image();
            image.Source = bitmap; 
           * */
            scatter.ItemsSource = Directory.GetFiles(@"C:\Users\mac3\Desktop\Websembly\Websembly\Pictures", "*.jpg");
        }

        private void TagVisualization1_Loaded(object sender, RoutedEventArgs e)
        {


            scatter.ItemsSource = Directory.GetFiles(@"C:\Users\mac3\Desktop\Websembly\Websembly\Pictures", "*.jpg");
        }

    }
}
