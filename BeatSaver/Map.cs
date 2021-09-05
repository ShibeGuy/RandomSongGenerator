using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Men.BeatSaver
{
    public class Map
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Uploader uploader { get; set; }
        public Metadata metadata { get; set; }
        public Stats stats { get; set; }
        public string uploaded { get; set; }
        public bool automapper { get; set; }
        public bool ranked { get; set; }
        public bool qualified { get; set; }
        public Version[] versions { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string lastPublishedAt { get; set; }
    }
}
