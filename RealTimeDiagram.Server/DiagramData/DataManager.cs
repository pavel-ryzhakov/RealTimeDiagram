using RealTimeDiagram.Server.Models;

namespace RealTimeDiagram.Server.DiagramData
{
    public class DataManager
    {
        public static List<DiagramModel> GetData()
        {
            var r = new Random();
            return new List<DiagramModel>()
            {
                new DiagramModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data1", BackgroundColor = "#5491DA" },
                new DiagramModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data2", BackgroundColor = "#E74C3C" },
                new DiagramModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data3", BackgroundColor = "#82E0AA" },
                new DiagramModel { Data = new List<int> { r.Next(1, 40) }, Label = "Data4", BackgroundColor = "#E5E7E9" }
            };
        }
    }
}
