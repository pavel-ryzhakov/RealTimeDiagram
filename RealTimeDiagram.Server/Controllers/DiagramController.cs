using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTimeDiagram.Server.DiagramData;
using RealTimeDiagram.Server.HubConfig;
using RealTimeDiagram.Server.TimerFeatures;

namespace RealTimeDiagram.Server.Controllers
{
    public class DiagramController : ControllerBase
    {
        private readonly IHubContext<DiagramHub> _hub;
        private readonly TimerManager _timer;

        public DiagramController(IHubContext<DiagramHub> hub, TimerManager timer)
        {
            _hub = hub;
            _timer = timer;
        }
        [HttpGet]
        public IActionResult Get()
        {
            if (!_timer.IsTimerStarted)
                _timer.PrepareTimer(() => _hub.Clients.All.SendAsync("TransferDiagramData", DataManager.GetData()));
            return Ok(new { Message = "Request Completed" });
        }
    }
}
