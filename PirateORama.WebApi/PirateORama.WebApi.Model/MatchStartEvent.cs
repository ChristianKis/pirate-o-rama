using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateORama.WebApi.Model
{
    public class MatchStartEvent : Event
    {
        public string  Name { get; set; }
        public MatchConfig Config { get; set; }
    }
}
