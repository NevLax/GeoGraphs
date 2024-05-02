
namespace GeoGraphs
{
    public class Graph
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public string ToString()
        {
            return Name + " " + Value;
        }
    }
}
