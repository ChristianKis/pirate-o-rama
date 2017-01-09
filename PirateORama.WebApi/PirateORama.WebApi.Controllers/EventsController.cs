using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using PirateORama.WebApi.Model;
using PirateORama.WebApi.Model.Repositories;
using Event = PirateORama.WebApi.Contracts.Event;

namespace PirateORama.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class EventsController : ApiController
    {
        private readonly IEventRepository _eventRepository;

        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        [Route("events/{name}")]
        public Event GetEvent(string name)
        {
            return _eventRepository.GetEvents()
                .OfType<MatchStartEvent>()
                .Select(_ => new Event()
                {
                    Name = _.Name,
                    Data = _.Config.ToString()
                })
                .FirstOrDefault(_ => _.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

        [Route("events")]
        public IEnumerable<Event> GetEvents()
        {
            return _eventRepository.GetEvents()
                .OfType<MatchStartEvent>()
                .Select(_ => new Event()
                {
                    Name = _.Name,
                    Data = _.Config.ToString()
                });
        }

    }
}
