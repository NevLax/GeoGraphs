using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace GeoGraphs
{
    public partial class PageJson : Page
    {
        ViewGraph vgraph;
        public PageJson()
        {
            InitializeComponent();
            vgraph = new ViewGraph();
        }

        private void btnser(object sender, RoutedEventArgs e)
        {
            var graphs = new ViewGraph();
            string jsonstring = JsonSerializer.Serialize(graphs);
            File.WriteAllText(@"D:\graphs.json", jsonstring);
            MessageBox.Show(jsonstring);
        }

        private void btndeser(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Json files (*.json)|*json";
            bool? succ = dialog.ShowDialog();
            if (succ == true)
            {
                try
                {
                    string json = File.ReadAllText(dialog.FileName);
                    vgraph = JsonSerializer.Deserialize<ViewGraph>(json);
                } catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            foreach (var item in vgraph.Graphs)
            {
                MessageBox.Show(item.ToString());
            }
        }

    }
}
