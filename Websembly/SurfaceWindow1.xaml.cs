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
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Collections; 
using System.ComponentModel;
using System.Data;



public class globalVariables{
    public static String originalHTMLPortfolioLayout =  "\n<html>\n\t<head>\n\t\t<style>\n\t\t</style>\n\t\t<title>YOUR TITLE HERE</title>\n\t</head>\n\t<body>\n\t\t<h1>YOUR TITLE HERE</h1>\n\t\t<div id='cover_photo'>\n\t\t\tP_Cover\n\t\t</div>\n\t\t<div id='portfolio_examples'>\n\t\t\t<div class='row'>\n\t\t\t\tP_R1L \n\t\t\t\tP_R1C \n\t\t\t\tP_R1R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_CR1L \n\t\t\t\tP_CR1C \n\t\t\t\tP_CR1R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_R2L \n\t\t\t\tP_R2C \n\t\t\t\tP_R2R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_CR2L \n\t\t\t\tP_CR2C \n\t\t\t\tP_CR2R>\n\t\t\t</div>\n\t\t</div>\n\t</body>\n</html>";
    public static void changeOriginalHTMLPortfolioLayout(String newHTML){
        originalHTMLPortfolioLayout = newHTML;
    }
    public static String file;
}
namespace SurfaceApplication1
{
    /// <summary>
    /// Interaction logic for SurfaceWindow1.xaml
    /// </summary>
    public partial class SurfaceWindow1 : SurfaceWindow
    {
        SurfaceButton selectedContentButton;
        int buttonInput;
        // Emily coding 11/22
        // Emily added 11/17 --> for library bar
        private ObservableCollection<PhotoData> libraryItems = new ObservableCollection<PhotoData>();
        private ObservableCollection<PhotoData> scatterItems = new ObservableCollection<PhotoData>();
        // Emily added 11/17 --> for library bar

        public ObservableCollection<PhotoData> LibraryItems
        {
            get { return libraryItems; }

        }

        public ObservableCollection<PhotoData> ScatterItems
        {
            get { return scatterItems; }
        }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public SurfaceWindow1()
        {
            InitializeComponent();

            // Add handlers for window availability events
            AddWindowAvailabilityHandlers();





        }

        /// <summary>
        /// Occurs when the window is about to close. 
        /// </summary>
        /// <param name="e"></param>

        // Emily added 11/17 --> for library bar
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            DataContext = this;

            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\doggy.jpg", "Doggy", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\duck.jpg", "Duck", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\kitties.jpg", "Kitties", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\elephant.jpg", "Elephant", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\otters.jpg", "Otters", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\racoon.jpg", "Racoon", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\teacup_pig.jpg", "Teacup Pig", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\two_pigs.jpg", "Two Pigs", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R1L.jpg", "caption_R1L", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R1C.jpg", "caption_R1C", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R1R.jpg", "caption_R1R", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R2L.jpg", "caption_R2L", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R2C.jpg", "caption_R2C", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\caption_R2R.jpg", "caption_R2R", true));
            LibraryItems.Add(new PhotoData(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\title.jpg", "title", true));

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Remove handlers for window availability events
            RemoveWindowAvailabilityHandlers();
        }

        /// <summary>
        /// Adds handlers for window availability events.
        /// </summary>
        private void AddWindowAvailabilityHandlers()
        {
            // Subscribe to surface window availability events
            ApplicationServices.WindowInteractive += OnWindowInteractive;
            ApplicationServices.WindowNoninteractive += OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable += OnWindowUnavailable;
        }

        /// <summary>
        /// Removes handlers for window availability events.
        /// </summary>
        private void RemoveWindowAvailabilityHandlers()
        {
            // Unsubscribe from surface window availability events
            ApplicationServices.WindowInteractive -= OnWindowInteractive;
            ApplicationServices.WindowNoninteractive -= OnWindowNoninteractive;
            ApplicationServices.WindowUnavailable -= OnWindowUnavailable;
        }

        /// Emily added 11/17 --> for library bar
        /// Added for the library Bar
        /// Grid Preview Touchdown handler 
        /// Added for Library Bar Implimentation 
        private void Grid_PreviewTouchDown(object sender, TouchEventArgs e)
        {
            //the touch position is stored here
            Point touchPosition;

            //get the position of the current touch
            touchPosition = e.Device.GetPosition(this);

            //create a new thickness to use as margin
            Thickness margin = new Thickness(touchPosition.X, touchPosition.Y, 0, 0);

            //set the margin to the new margin
            // label1.Margin = margin;

            //make the label visible
            //label1.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// This is called when the user can interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowInteractive(object sender, EventArgs e)
        {
            //TODO: enable audio, animations here
        }

        /// <summary>
        /// This is called when the user can see but not interact with the application's window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowNoninteractive(object sender, EventArgs e)
        {
            //TODO: Disable audio here if it is enabled

            //TODO: optionally enable animations here
        }

        private String getHTML(String locationOfChange, String change)
        {
            String html = globalVariables.originalHTMLPortfolioLayout; //"\n<html>\n\t<head>\n\t\t<style>\n\t\t</style>\n\t\t<title>YOUR TITLE HERE</title>\n\t</head>\n\t<body>\n\t\t<h1>YOUR TITLE HERE</h1>\n\t\t<div id='cover_photo'>\n\t\t\tP_Cover\n\t\t</div>\n\t\t<div id='portfolio_examples'>\n\t\t\t<div class='row'>\n\t\t\t\tP_R1L \n\t\t\t\tP_R1C \n\t\t\t\tP_R1R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_CR1L \n\t\t\t\tP_CR1C \n\t\t\t\tP_CR1R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_R2L \n\t\t\t\tP_R2C \n\t\t\t\tP_R2R\n\t\t\t</div>\n\t\t\t<div class='row'>\n\t\t\t\tP_CR2L \n\t\t\t\tP_CR2C \n\t\t\t\tP_CR2R>\n\t\t\t</div>\n\t\t</div>\n\t</body>\n</html>";
            int indexStart = html.IndexOf(locationOfChange);
            html = html.Replace(locationOfChange, change);
            globalVariables.changeOriginalHTMLPortfolioLayout(html);
            int lengthOfChange = change.Length;
            // html.select(indexStart, lengthOfChange);
            // html.SelectorColor = Color.pink;

            return html;
        }

        /// <summary>
        /// This is called when the application's window is not visible or interactive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnWindowUnavailable(object sender, EventArgs e)
        {
            //TODO: disable audio, animations here

        }

        //DRAG AND DROP CODE (until end of drag and drop comment)
        // Comment out if testing Library Container 
        //private void Scatter_PreviewTouchDown(object sender, TouchEventArgs e)
        //{
        //    FrameworkElement findSource = e.OriginalSource as FrameworkElement;
        //    ScatterViewItem draggedElement = null;

        //    // Find the ScatterViewitem object that is being touched.
        //    while (draggedElement == null && findSource != null)
        //    {
        //        if ((draggedElement = findSource as ScatterViewItem) == null)
        //        {
        //            findSource = VisualTreeHelper.GetParent(findSource) as FrameworkElement;
        //        }
        //    }

        //    if (draggedElement == null)
        //    {
        //        return;
        //    }

        //    PhotoData data = draggedElement.Content as PhotoData;

        //    // Create the cursor visual
        //    ContentControl cursorVisual = new ContentControl()
        //    {
        //        Content = draggedElement.DataContext,
        //        Style = FindResource("CursorStyle") as Style
        //    };

        //    // Create a list of input devices. Add the touches that
        //    // are currently captured within the dragged element and
        //    // the current touch (if it isn't already in the list).
        //    List<InputDevice> devices = new List<InputDevice>();
        //    devices.Add(e.TouchDevice);
        //    foreach (TouchDevice touch in draggedElement.TouchesCapturedWithin)
        //    {
        //        if (touch != e.TouchDevice)
        //        {
        //            devices.Add(touch);

        //        }
        //    }

        //    // Get the drag source object
        //    ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);

        //    SurfaceDragDrop.BeginDragDrop(
        //        dragSource,                     // The ScatterView object that the cursor is dragged out from.
        //        draggedElement,                 // The ScatterViewItem object that is dragged from the drag source.
        //        cursorVisual,                   // The visual element of the cursor.
        //        draggedElement.DataContext,     // The data attached with the cursor.
        //        devices,                        // The input devices that start dragging the cursor.
        //        DragDropEffects.All);          // The allowed drag-and-drop effects of this operation.

        //    // Prevents the default touch behavior from happening and disrupting our code.
        //    e.Handled = true;

        //    // Hide the ScatterViewItem for now. We will remove it if the DragDrop is successful.
        //    draggedElement.Visibility = Visibility.Hidden;
        //}

        //private void Scatter_DragCanceled(object sender, SurfaceDragDropEventArgs e)
        //{
        //    PhotoData data = e.Cursor.Data as PhotoData;
        //    ScatterViewItem svi = scatter.ItemContainerGenerator.ContainerFromItem(data) as ScatterViewItem;
        //    if (svi != null)
        //    {
        //        svi.Visibility = Visibility.Visible;
        //    }
        //}

        //private void Scatter_DragCompleted(object sender, SurfaceDragCompletedEventArgs e)
        //{
        //    if (e.Cursor.CurrentTarget != scatter && e.Cursor.Effects == DragDropEffects.Move)
        //    {
        //        ScatterItems.Remove(e.Cursor.Data as PhotoData);
        //        e.Handled = true;
        //    }
        //}

        //private void Scatter_Drop(object sender, SurfaceDragDropEventArgs e)
        //{
        //    // If it isn't already on the ScatterView, add it to the source collection.
        //    if (!ScatterItems.Contains(e.Cursor.Data))
        //    {
        //        ScatterItems.Add((PhotoData)e.Cursor.Data);
        //    }

        //    // Get the ScatterViewItem that Scatter automatically generated.
        //    ScatterViewItem svi =
        //        scatter.ItemContainerGenerator.ContainerFromItem(e.Cursor.Data) as ScatterViewItem;
        //    svi.Visibility = System.Windows.Visibility.Visible;
        //    svi.Width = e.Cursor.Visual.ActualWidth;
        //    svi.Height = e.Cursor.Visual.ActualHeight;
        //    svi.Center = e.Cursor.GetPosition(scatter);
        //    svi.Orientation = e.Cursor.GetOrientation(scatter);
        //    svi.Background = Brushes.Transparent;
        //    // Setting e.Handle to true ensures that default behavior is not performed.
        //    e.Handled = true;
        //}

        //private void ListBox_PreviewTouchDown(object sender, TouchEventArgs e)
        //{
        //    FrameworkElement findSource = e.OriginalSource as FrameworkElement;
        //    SurfaceListBoxItem draggedElement = null;

        //    // Find the SurfaceListBoxItem object that is being touched.
        //    while (draggedElement == null && findSource != null)
        //    {
        //        if ((draggedElement = findSource as SurfaceListBoxItem) == null)
        //        {
        //            findSource = VisualTreeHelper.GetParent(findSource) as FrameworkElement;
        //        }
        //    }

        //    if (draggedElement == null)
        //    {
        //        return;
        //    }

        //    PhotoData data = draggedElement.Content as PhotoData;

        //    // Create the cursor visual
        //    ContentControl cursorVisual = new ContentControl()
        //    {
        //        Content = draggedElement.DataContext,
        //        Style = FindResource("CursorStyle") as Style
        //    };

        //    // Create a list of input devices. Add the touches that
        //    // are currently captured within the dragged element and
        //    // the current touch (if it isn't already in the list).
        //    List<InputDevice> devices = new List<InputDevice>();
        //    devices.Add(e.TouchDevice);
        //    foreach (TouchDevice touch in draggedElement.TouchesCapturedWithin)
        //    {
        //        if (touch != e.TouchDevice)
        //        {
        //            devices.Add(touch);
        //        }
        //    }

        //    // Get the drag source object
        //    ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);

        //    SurfaceDragDrop.BeginDragDrop(
        //        dragSource,
        //        draggedElement,
        //        cursorVisual,
        //        draggedElement.DataContext,
        //        devices,
        //        DragDropEffects.Move);

        //    // Prevents the default touch behavior from happening and disrupting our code.
        //    e.Handled = true;

        //    // Gray out the SurfaceListBoxItem for now. We will remove it if the DragDrop is successful.
        //    draggedElement.Opacity = 0.5;
        //}

        //private void ListBox_DragCanceled(object sender, SurfaceDragDropEventArgs e)
        //{
        //    PhotoData data = e.Cursor.Data as PhotoData;
        //    SurfaceListBoxItem boxItem = ListBox.ItemContainerGenerator.ContainerFromItem(data) as SurfaceListBoxItem;
        //    if (boxItem != null)
        //    {
        //        boxItem.Opacity = 1.0;
        //    }
        //}

        //private void ListBox_DragCompleted(object sender, SurfaceDragCompletedEventArgs e)
        //{
        //if (e.Cursor.CurrentTarget != ListBox && e.Cursor.Effects == DragDropEffects.Move)
        //{
        //    LibraryItems.Remove(e.Cursor.Data as PhotoData);
        //    e.Handled = true;
        //}
        //}

        //private void ListBox_Drop(object sender, SurfaceDragDropEventArgs e)
        //{
        //    // If it isn't already on the ListBox, add it to the source collection.
        //    if (!LibraryItems.Contains(e.Cursor.Data))
        //    {
        //        LibraryItems.Add((PhotoData)e.Cursor.Data);
        //    }

        //    // Get the SurfaceListBoxItem that ListBox automatically generated.
        //    SurfaceListBoxItem boxItem =
        //        ListBox.ItemContainerGenerator.ContainerFromItem(e.Cursor.Data) as SurfaceListBoxItem;
        //    boxItem.Visibility = System.Windows.Visibility.Visible;
        //    // Setting e.Handle to true ensures that default behavior is not performed.
        //    e.Handled = true;
        //}

        //void Canvas_Drop(object sender, DragEventArgs e)
        //{
        //    PhotoData pic = (PhotoData)e.Data.GetData(typeof(PhotoData));
        //    if (pic != null)
        //    {
        //        Canvas canvas = e.Source as Canvas;
        //        Point p = e.GetPosition(canvas);

        //        ContentControl c = new ContentControl();
        //        c.Content = pic;
        //        Canvas.SetLeft(c, p.X);
        //        Canvas.SetTop(c, p.Y);
        //        canvas.Children.Add(c);
        //    }
        //    (e.Source as Canvas).Background = Brushes.LightGray;
        //} 

        // End of Drag and Drop code


        // LIBRARY CONTAINER CODE (until end of library bar code comment)
        // Comment out if testing drag and drop code

        ///USE THIS METHOD TO PROGRAM BEHAVIOR OF WHERE WILL GO
        /// will be used when the user touches an element on the scatterview
        /// will gather the required data for the drag and drop operation and start it
        /// once user has dropped item, either a DragCanceled or DragCompleted event will be fired,
        /// depending on where the item is dropped 
        /// if they drop the item on the ScatterView or LibraryContainer the DragCompleted Event will fire
        /// if they drop it to the left of the right of the LibraryContainer the DragCanceled event will fire 


        //private void Scatter_Drop(object sender, SurfaceDragDropEventArgs e)
        //{
        //    // If it isn't already on the ScatterView, add it to the source collection.
        //    if (!ScatterItems.Contains(e.Cursor.Data))
        //    {
        //        ScatterItems.Add((PhotoData)e.Cursor.Data);
        //    }

        //    // Get the ScatterViewItem that Scatter automatically generated.
        //    ScatterViewItem svi =
        //        P_R1L_Label.ItemContainerGenerator.ContainerFromItem(e.Cursor.Data) as ScatterViewItem;
        //    svi.Visibility = System.Windows.Visibility.Visible;
        //    svi.Width = e.Cursor.Visual.ActualWidth;
        //    svi.Height = e.Cursor.Visual.ActualHeight;
        //    svi.Center = e.Cursor.GetPosition(scatter);
        //    svi.Orientation = e.Cursor.GetOrientation(scatter);
        //    svi.Background = Brushes.Transparent;
        //    // Setting e.Handle to true ensures that default behavior is not performed.
        //    e.Handled = true;
        //}



        

        //Code for display the content after you "drop" it into its place
        private void OnDropTargetDrop1(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //PhotoData data = e.Cursor.Data as PhotoData; //AS DOES NOT THROW EXCEPTION, THIS IS AN INVALID CAST -> data REMAINS null
                //PhotoData data = (PhotoData)e.Cursor.Data;

                //ScatterViewItem draggedElement = null;
                //ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);
                // Image image = sender as Image; 
                //Image image = e.Cursor.Data as Image; //image remains null here

                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\doggy.jpg", UriKind.Relative));
                P_R1L_Label.Background = myBrush;

               // String imageLabel = "File Name" + " Caption"; //Instead, we want to pull file name of picture being dragged here 
                //int number = 12;
                //CR1L_Label.Content = imageLabel;
                //CR1L_Label.FontSize = number;
                //CR1L_Label.Background = Brushes.Transparent;
            }

            catch(Exception error)
            {
                Console.Out.Write(error);
            }
        }

         //Code for display the content after you "drop" it into its place
        private void OnDropTargetDrop2(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\duck.jpg", UriKind.Relative));
                P_R1C_Label.Background = myBrush;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }


         //Code for display the content after you "drop" it into its place
        private void OnDropTargetDrop3(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\kitties.jpg", UriKind.Relative));
                P_R1R_Label.Background = myBrush;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }


        private void OnDropTargetDrop4(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\elephant.jpg", UriKind.Relative));
                P_R2L_Label.Background = myBrush;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        private void OnDropTargetDrop5(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
          
                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\otters.jpg", UriKind.Relative));
                P_R2C_Label.Background = myBrush;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }



        private void OnDropTargetDrop6(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //PhotoData data = e.Cursor.Data as PhotoData; //AS DOES NOT THROW EXCEPTION, THIS IS AN INVALID CAST -> data REMAINS null
                //PhotoData data = (PhotoData)e.Cursor.Data;

                //ScatterViewItem draggedElement = null;
                //ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);
                // Image image = sender as Image; 
                //Image image = e.Cursor.Data as Image; //image remains null here

                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\racoon.jpg", UriKind.Relative));
                P_R2R_Label.Background = myBrush;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }


         //Code for display the content after you "drop" it into its place
        private void OnDropTargetDrop(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //PhotoData data = e.Cursor.Data as PhotoData; //AS DOES NOT THROW EXCEPTION, THIS IS AN INVALID CAST -> data REMAINS null
                //PhotoData data = (PhotoData)e.Cursor.Data;

                //ScatterViewItem draggedElement = null;
                //ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);
                // Image image = sender as Image; 
                //Image image = e.Cursor.Data as Image; //image remains null here

                ImageBrush myBrush = new ImageBrush();
                BitmapImage bitmapImage = new BitmapImage();

                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Downloads\Websembly.1-11.17.13\Websembly\images\doggy.jpg", UriKind.Relative));
                P_R1L_Label.Background = myBrush;


                //Stuff for Caption 
                String imageLabel = "File Name" + " Caption"; //Instead, we want to pull file name of picture being dragged here 
                int number = 12;
                CR1L_Label.Content = imageLabel;
                CR1L_Label.FontSize = number;
                CR1L_Label.Background = Brushes.Transparent;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        //Code for Caption
        private void OnDropTargetDropCaption1(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R1L.jpg", UriKind.Relative));
                CR1L_Label.Background = myBrushCaption; 
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        private void OnDropTargetDropCaption2(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R1C.jpg", UriKind.Relative));
                CR1C_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        private void OnDropTargetDropCaption3(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R1R.jpg", UriKind.Relative));
                CR1R_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        private void OnDropTargetDropCaption4(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R2L.jpg", UriKind.Relative));
                CR2L_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        private void OnDropTargetDropCaption5(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R2C.jpg", UriKind.Relative));
                CR2C_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }
        private void OnDropTargetDropCaption6(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\caption_R2R.jpg", UriKind.Relative));
                CR2R_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }

        //Code for Title 
        private void OnDropTargetDropTitle(object sender, SurfaceDragDropEventArgs e)
        {
            try
            {
                //Stuff for Caption 
                ImageBrush myBrushCaption = new ImageBrush();
                BitmapImage bitmapImageCaption = new BitmapImage();
                myBrushCaption.ImageSource = new BitmapImage(new Uri(@"C:\Users\balichmac1\Desktop\Websembly Demo ReVamp\Resources\Icons\title.jpg", UriKind.Relative));
                P_Cover_Label.Background = myBrushCaption;
            }

            catch (Exception error)
            {
                Console.Out.Write(error);
            }
        }
       



        private void OnDropTargetDragEnter(object sender, SurfaceDragDropEventArgs e)
        {
            PhotoData data = e.Cursor.Data as PhotoData;


            if (!data.CanDrop)
            {
                e.Effects = DragDropEffects.Move;

            }
            if (data.CanDrop)
            {
                MessageBox.Show("hi");
            }

        }


        //private void OnDropTargetDragLeave(object sender, SurfaceDragDropEventArgs e)
        //{
        //    PhotoData data = e.Cursor.Data as PhotoData;
        //    if (e.Cursor.Effects == DragDropEffects.Move)
        //    {
        //        LibraryItems.Remove(e.Cursor.Data as PhotoData);
        //        e.Handled = true;
        //    }
        //}

        private void OnTargetChanged(object sender, TargetChangedEventArgs e)
        {
            if (e.Cursor.CurrentTarget != null)
            {
                PhotoData data = e.Cursor.Data as PhotoData;
                e.Cursor.Visual.Tag = (data.CanDrop) ? "CanDrop" : "CannotDrop";
            }
            else
            {
                e.Cursor.Visual.Tag = null;
            }
        }

        private void Scatter_PreviewTouchDown(object sender, TouchEventArgs e)
        {
            FrameworkElement findSource = e.OriginalSource as FrameworkElement;
            ScatterViewItem draggedElement = null;

            //find the ScatterViewItem object that is being touched 
            while (draggedElement == null && findSource != null)
            {
                if ((draggedElement = findSource as ScatterViewItem) == null)
                {
                    findSource = VisualTreeHelper.GetParent(findSource) as FrameworkElement;
                }

            }
            if (draggedElement == null)
            {
                return;
            }
            PhotoData data = draggedElement.Content as PhotoData;

            //create the cursor visual
            //CAN BE CREATIVE HERE
            ContentControl cursorVisual = new ContentControl()
            {
                Content = draggedElement.DataContext,
                Style = FindResource("CursorStyle") as Style
            };

            //create the list of input devices ADD THE FIDUCIAL MARKERS HEREEEE
            //add the touches that are currently captured within the dragged elt and
            //the current touch (if it isn't already in the list)
            List<InputDevice> devices = new List<InputDevice>();
            devices.Add(e.TouchDevice);
            foreach (TouchDevice touch in draggedElement.TouchesCapturedWithin)
            {
                if (touch != e.TouchDevice)
                {
                    devices.Add(touch);
                }

            }
            //get the drag source object
            ItemsControl dragSource = ItemsControl.ItemsControlFromItemContainer(draggedElement);

            //the scatterview object that the cursor is dragged out from
            SurfaceDragDrop.BeginDragDrop(
                dragSource, //the scatterview object that the cursor is dragged out from
                draggedElement, //the ScatterViewItem object that is dragged from the drag source
                cursorVisual, //the visual element of the cursor
                draggedElement.DataContext, //the data attached with the cursor
                devices, //the input devices that start dragging the cursor
                DragDropEffects.None); //the allowed drag-and-drop

            //this prevents the default touch operator from happening
            e.Handled = true;

            //hide the scatterviewitem for now. we will remove it if the dragdrop is successful
            draggedElement.Visibility = Visibility.Hidden; 
        }


        ////this is for the LibraryBar drag and drop
        ////will restore the scatterviewitem to visible when the user drops the item where it is not able
        ////to be dropped
        //private void Scatter_DragCanceled(object sender, SurfaceDragDropEventArgs e)
        //{
        //    PhotoData data = e.Cursor.Data as PhotoData;
        //    ScatterViewItem svi = scatter.ItemContainerGenerator.ContainerFromItem(data) as ScatterViewItem;
        //    if (svi != null)
        //    {
        //        svi.Visibility = Visibility.Visible;
        //    }
        //}

        ////will complete the drag operation by removing the item from the source collection
        ////if the current effect was copy then you would not remove it 
        //private void Scatter_DragCompleted(object sender, SurfaceDragCompletedEventArgs e)
        //{

        //    if (e.Cursor.CurrentTarget != scatter && e.Cursor.Effects == DragDropEffects.Move)
        //    {
        //        ScatterItems.Remove(e.Cursor.Data as PhotoData);
        //        e.Handled = true;
        //    }

        //}

        private void SurfaceWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }
        //Library bar code ends

        //Alex started writing methods for the buttons here
        //SAVE POINT: 11/10/13 4:11pm

        System.Windows.Controls.ContentPresenter FindContentPresenter(DependencyObject obj)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is System.Windows.Controls.ContentPresenter)
                {
                    return (System.Windows.Controls.ContentPresenter)child;
                }
                else
                {
                    System.Windows.Controls.ContentPresenter childOfChild =
                        FindContentPresenter(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        /* Used this when we had buttons
        private void SurfaceButton_Click(object sender, RoutedEventArgs e)
            {

                Button b = (Button)e.Source as Button;

                if (b.Equals(P_Cover))
                {
                    MessageBox.Show("Hello, Alex.");
                }

                if (b.Equals(Text))
                {
                    selectedContentButton.Content = "Text";
                    String change = "<p>PUT YOUR TEXT HERE</p>";
                    generatedCode.Content =  getHTML(selectedContentButton.Name, change);
                
                    //generatedCode.Content = generatedCode.Content + "<p>PUT YOUR TEXT HERE</p>";
                }

                if (b.Equals(Picture))
                {
                   
                    selectedContentButton.Content = "Picture";
                    String change = "<p><img src='PUT YOUR IMAGE FILE PATH HERE alt='PUT A DESCRIPTION OF THE IMAGE HERE'></p>";
                    generatedCode.Content = getHTML(selectedContentButton.Name, change);
                    //generatedCode.Content = generatedCode.Content + "<p><img src='PUT YOUR IMAGE FILE PATH HERE' alt='DESCRIPTION OF IMAGE HERE'></p>";
                }


                if (b.Equals(Video))
                {
                    selectedContentButton.Content = "Video";
                    String change = "<p><embed src='PUT YOUR VIDEO FILE PATH HERE' height='200' width='200'>";
                

                    generatedCode.Content = getHTML(selectedContentButton.Name, change);
                
                    //generatedCode.Content = generatedCode.Content + "<p><embed src='FILE PATH TO VIDEO HERE' height='200' width='200'></p>";
                }

                if (b.Equals(None))
                {
                    String change = "";
                    generatedCode.Content = getHTML(selectedContentButton.Name, change);
                    selectedContentButton.Content = "Empty";
                }
            }
        */


        /*
        //Code for selection
        private void unselectall()
        {
            P_Cover.Background = Brushes.LightSteelBlue;

            //Row 1 Media
            P_R1L.Background = Brushes.LightSteelBlue;
            P_R1C.Background = Brushes.LightSteelBlue;
            P_R1R.Background = Brushes.LightSteelBlue;

            //Row 1 Captions
            C_R1L.Background = Brushes.LightSteelBlue;
            C_R1C.Background = Brushes.LightSteelBlue;
            C_R1R.Background = Brushes.LightSteelBlue;

            //Row 2 Media
            P_R2L.Background = Brushes.LightSteelBlue;
            P_R2C.Background = Brushes.LightSteelBlue;
            P_R2R.Background = Brushes.LightSteelBlue; 

            //Row 2 Captions 
            C_R2L.Background = Brushes.LightSteelBlue;
            C_R2C.Background = Brushes.LightSteelBlue;
            C_R2R.Background = Brushes.LightSteelBlue; 

        }

         * */


        /*
        //Code for ContentButton_Click
        private void ContentButton_Click(object sender, RoutedEventArgs e)
        {
            Picture.Visibility = Visibility.Visible;
            Video.Visibility = Visibility.Visible;
            Text.Visibility = Visibility.Hidden;
            None.Visibility = Visibility.Visible;

            selectedContentButton = sender as SurfaceButton;
            unselectall();
            selectedContentButton.Background = Brushes.SteelBlue;
          
            Button b = (Button)e.Source as Button;
            
            if (b.Equals(P_Cover))
            {
                buttonInput = 1;

                P_Cover.Visibility = Visibility.Hidden;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;
            }
           
            if (b.Equals(P_R1L))
            {
                buttonInput = 2;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Hidden;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Hidden;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;
                
            }

            if (b.Equals(P_R1C))
            {
                buttonInput = 3;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Hidden;
                P_R1C.Visibility = Visibility.Hidden;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Hidden;
                P_R2C.Visibility = Visibility.Hidden;
                P_R2R.Visibility = Visibility.Hidden;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(P_R1R))
            {
                buttonInput = 4;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(C_R1L))
            {
                buttonInput = 5;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Hidden;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(C_R1C))
            {
                buttonInput = 6;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Hidden;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(C_R1R))
            {
                buttonInput = 7;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Hidden;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;
            }

            if (b.Equals(P_R2L))
            {
                buttonInput = 8;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Hidden;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(P_R2C))
            {
                buttonInput = 9;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Hidden;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Hidden;
                P_R2C.Visibility = Visibility.Hidden;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;

            }

            if (b.Equals(P_R2R))
            {
                buttonInput = 10;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Hidden;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Hidden;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Hidden;
                P_R2C.Visibility = Visibility.Hidden;
                P_R2R.Visibility = Visibility.Hidden;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;
            }

            
            if (b.Equals(C_R2L))
            {
                buttonInput = 11;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Hidden;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Visible;
            }
            if (b.Equals(C_R2C))
            {
                buttonInput = 12;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Hidden;
                C_R2R.Visibility = Visibility.Visible;
            }
            if (b.Equals(C_R2R))
            {
                buttonInput = 13;

                P_Cover.Visibility = Visibility.Visible;
                P_R1L.Visibility = Visibility.Visible;
                P_R1C.Visibility = Visibility.Visible;
                P_R1R.Visibility = Visibility.Visible;
                C_R1L.Visibility = Visibility.Visible;
                C_R1C.Visibility = Visibility.Visible;
                C_R1R.Visibility = Visibility.Visible;
                P_R2L.Visibility = Visibility.Visible;
                P_R2C.Visibility = Visibility.Visible;
                P_R2R.Visibility = Visibility.Visible;
                C_R2L.Visibility = Visibility.Visible;
                C_R2C.Visibility = Visibility.Visible;
                C_R2R.Visibility = Visibility.Hidden;
  
            }
        }
   */

        /*
        //Code for CaptionButton_Click
        private void CaptionButton_Click(object sender, RoutedEventArgs e)
        {
            Picture.Visibility = Visibility.Hidden;
            Video.Visibility = Visibility.Hidden;
            Text.Visibility = Visibility.Visible;
            None.Visibility = Visibility.Visible;

            selectedContentButton = sender as SurfaceButton;
            unselectall();
            selectedContentButton.Background = Brushes.SteelBlue;
        }
         
    }
         * */
    }
}
