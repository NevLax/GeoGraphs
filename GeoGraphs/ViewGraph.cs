
namespace GeoGraphs
{
    public class ViewGraph
    {
        public List<Graph> Graphs { get; set;} = new List<Graph>();

        public ViewGraph()
        {
            Graphs = [
                new Graph() { Name = "first", Value = 0},
                new Graph() { Name = "second", Value = 1},
                new Graph() { Name = "therd", Value = 2},
                new Graph() { Name = "abobus", Value = -3}
            ];
        }
    }
}
