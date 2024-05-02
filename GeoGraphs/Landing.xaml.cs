using System.Windows;
using System.Windows.Controls;

namespace GeoGraphs
{
    public partial class Landing : Page
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}
