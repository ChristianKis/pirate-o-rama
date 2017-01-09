using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirateORama.WebApi.Model;
using PirateORama.WebApi.Model.Repositories;

namespace PirateORama.WebApi.Repositories
{
    public class InmemoryEventRepository : IEventRepository
    {
        public IEnumerable<Event> GetEvents()
        {
            return new[]
           {
                new MatchStartEvent
                {
                    Name = "FirstMatch",
                    Config = new MatchConfig()
                }, 
                new MatchStartEvent {
                    Name = "SecondMatch",
                    Config = new MatchConfig()
                },
            };
        }
    }
}
