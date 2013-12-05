using System;
using System.Collections.Generic;
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

namespace SurfaceApplication1
{
    /// <summary>
    /// Interaction logic for TagVisualization2.xaml
    /// </summary>
    public partial class TagVisualization2 : TagVisualization
    {
        public TagVisualization2()
        {
            InitializeComponent();
        }

        private void TagVisualization2_Loaded(object sender, RoutedEventArgs e)
        {
            MessageText.Inlines.Add("Hi, I'm Alex Poon and I love to swim.");
            MessageText.Inlines.Add("I've won quite a few Olympics in my time - I was a Gold medalist in the 50 Freestyler, 100 Breaststroker, and 400 IMer. ");
            MessageText.Inlines.Add("I also love to teach people how to swim. 5 years ago, I began my work with Michael Phelps and singlehandedly taught him how to swim. ");
            MessageText.Inlines.Add("For any inquiries about swim lessons, please contact my secretary, Monica Starr Feldman.");
        }
    }
}
