using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo_3_Paragon_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();
            Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView().DataRequested += MainPage_DataRequested;
        }

        void MainPage_DataRequested(Windows.ApplicationModel.DataTransfer.DataTransferManager sender, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs args)
        {
            Uri URI = new Uri("https://www.microsoft.com/store/apps/9nblggh4sgl7");
            args.Request.Data.SetWebLink(URI);
            args.Request.Data.Properties.Title = "Diablo 3 Paragon Calculator";
            args.Request.Data.Properties.Description = "With this application you can see how many levels you going when the season is finished.";
        }

        private void calcBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
            // Create run and set text
            Run run = new Run();
            run.Text = "This is a free software to calculate your Paragon level.";
            Run run1 = new Run();
            run1.Text = "All copyrightes for pictures reserved by Blizzard Entairtaiment";

            // Create paragraph
            Paragraph paragraph = new Paragraph();
            Paragraph paragraph1 = new Paragraph();

            // Add run to the paragraph
            paragraph.Inlines.Add(run);
            paragraph1.Inlines.Add(run1);
            Copyright.Blocks.Add(paragraph);
            Copyright.Blocks.Add(paragraph1);
        }
    }

}
