namespace RealTimeDiagram.Server.Models
{
    public class DiagramModel
    {
        public List<int> Data { get; set; }
        public string? Label { get; set; }
        public string? BackgroundColor { get; set; }
        public DiagramModel()
        {
            Data = new List<int>();
        }
    }
}
