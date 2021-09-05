using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Men.BeatSaver
{
    public class Version
    {
        public string hash { get; set; }
        public string key { get; set; }
        public string state { get; set; }
        public string createdAt { get; set; }
        public int sageScore { get; set; }
        public Difficulty[] diffs { get; set; }
        public string downloadURL { get; set; }
        public string coverURl { get; set; }
        public string previewURL { get; set; }

    }
}
