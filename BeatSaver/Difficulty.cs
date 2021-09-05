using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Men.BeatSaver
{
    public class Difficulty
    {
        public double njs { get; set; }
        public double offset { get; set; }
        public int notes { get; set; }
        public int bombs { get; set; }
        public int obstacles { get; set; }
        public double nps { get; set; }
        public double length { get; set; }
        public string characteristic { get; set; }
        public string difficulty { get; set; }
        public int events { get; set; }
        public bool chroma { get; set; }
        public bool me { get; set; } // Mapping Extensions
        public bool ne { get; set; } // Noodle Extensions
        public bool cinema { get; set; }
        public double seconds { get; set; }
        public Parity paritySummary { get; set; }

    }
}
