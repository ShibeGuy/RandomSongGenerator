using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Men.BeatSaver;
using Random_Song_Generator;
using System.Windows.Forms;

namespace Men.Utilities
{
    class RandomBeatSaver
    {
        Label status = null;
        
        public RandomBeatSaver() {
        }
        public RandomBeatSaver(Label output)
        {
            status = output;
        }
        
        public Map Next()
        {
            return RandomMap();
        }
        private static HttpClient client = new HttpClient();

        private static int hexToNum(string hex)
        {

            int num = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return num;
        }

        private static string numToHex(int num)
        {
            return Convert.ToString(num,16);
        }

        private static string latestHex()
        {
            string latest = "https://api.beatsaver.com/maps/latest?sort=LAST_PUBLISHED";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, latest);
            var userAgent = new ProductInfoHeaderValue("DipsonsRandomKeyGen", "0.1");
            request.Headers.UserAgent.Add(userAgent);
            HttpResponseMessage resp = client.SendAsync(request).Result;
            string content = resp.Content.ReadAsStringAsync().Result;
            Latest obj = JsonConvert.DeserializeObject<Latest>(content);


            return obj.docs[0].id;
        }

        private static Map GetMap(string key)
        {
            

            string url = "https://api.beatsaver.com/maps/id/" + key;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            var userAgent = new ProductInfoHeaderValue("DipsonsRandomKeyGen", "0.1");
            request.Headers.UserAgent.Add(userAgent);
            HttpResponseMessage resp = client.SendAsync(request).Result;
            string content = resp.Content.ReadAsStringAsync().Result;
            Map map;
            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                map = JsonConvert.DeserializeObject<Map>(content);
                return map;
            }
            return new Map();
        }
        public void WriteTextSafe(string text)
        {
            if(status != null)
            {
                if (status.InvokeRequired)
                {
                    
                    Action safeWrite = delegate { WriteTextSafe($"{text}"); };
                    status.Invoke(safeWrite);
                }
                else
                    status.Text = text;
            }

        }
        private static bool CheckMap(string key)
        {
            bool mapAvailable = false;

            string url = "https://api.beatsaver.com/maps/id/" + key;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            var userAgent = new ProductInfoHeaderValue("DipsonsRandomKeyGen", "0.1");
            request.Headers.UserAgent.Add(userAgent);
            HttpResponseMessage resp = client.SendAsync(request).Result;
            

            if (resp.StatusCode == System.Net.HttpStatusCode.OK){
                mapAvailable = true;
            }
            return mapAvailable;
        }


        private Map RandomMap()
        {
            bool AllowAutomapped = (Filters.filter & FilterBits.AllowAutomapped) == FilterBits.AllowAutomapped;
            bool AllowNoodleExtensions = (Filters.filter & FilterBits.AllowNoodleExtensions) == FilterBits.AllowNoodleExtensions;
            bool AllowMappingExtensions = (Filters.filter & FilterBits.AllowMappingExtensions) == FilterBits.AllowMappingExtensions;
            bool AllowChroma = (Filters.filter & FilterBits.AllowChroma) == FilterBits.AllowChroma;
            bool AllowCinema = (Filters.filter & FilterBits.AllowCinema) == FilterBits.AllowCinema;

            bool OnlyAutomapped = (Filters.filter & FilterBits.OnlyAutomapped) == FilterBits.OnlyAutomapped;
            bool OnlyNoodleExtensions = (Filters.filter & FilterBits.OnlyNoodleExtensions) == FilterBits.OnlyNoodleExtensions;
            bool OnlyMappingExtensions = (Filters.filter & FilterBits.OnlyMappingExtensions) == FilterBits.OnlyMappingExtensions;
            bool OnlyChroma = (Filters.filter & FilterBits.OnlyChroma) == FilterBits.OnlyChroma;
            bool OnlyCinema = (Filters.filter & FilterBits.OnlyCinema) == FilterBits.OnlyCinema;


            bool CheckNe = false;
            bool CheckMe = false;
            bool CheckChroma = false;
            bool CheckCinema = false;


            string newestHex = "";
            int num = 0;
            string pickedMap = "";

            newestHex = latestHex();
            num = random(hexToNum(newestHex)); // returns random int between 0 and latest map
            pickedMap = numToHex(num);
            WriteTextSafe($"Generated hex key: {pickedMap}, checking if valid.");
            if (CheckMap(pickedMap)){
                WriteTextSafe($"Map is valid.");
                Map map = GetMap(pickedMap);
                
                
                
                
                foreach(Difficulty d in map.versions[0].diffs)
                {
                    if (d.ne)
                        CheckNe = true;
                    if (d.me)
                        CheckMe = true;
                    if (d.cinema)
                        CheckCinema = true;
                    if (d.chroma)
                        CheckChroma = true;
                }
                if(CheckNe) // Map has a difficulty with noodle extensions
                {
                    if (!AllowNoodleExtensions)
                    {
                        WriteTextSafe($"Map has a difficulty with Noodle Extensions, retrying.");
                        return RandomMap();
                    }
                }
                else // Map has no difficulties with NE
                {
                    if (OnlyNoodleExtensions)
                    {
                        WriteTextSafe($"Map has no difficulties with Noodle Extensions, retrying.");
                        return RandomMap();
                    }
                }
                if (CheckMe)
                {
                    if (!AllowMappingExtensions)
                    {
                        WriteTextSafe($"Map has a difficulty with Mapping Extensions, retrying.");
                        return RandomMap();
                    }
                }
                else
                {
                    if (OnlyMappingExtensions)
                    {
                        WriteTextSafe($"Map has no difficulties with Mapping Extensions, retrying.");
                        return RandomMap();

                    }
                        
                }
                if (CheckCinema)
                {
                    if (!AllowCinema)
                    {
                        WriteTextSafe($"Map has a difficulty with Cinema, retrying.");
                        return RandomMap();
                    }
                }
                else
                {
                    if (OnlyCinema)
                    {
                        WriteTextSafe($"Map has no difficulties with Cinema, retrying.");
                        return RandomMap();
                    }
                }
                if (CheckChroma)
                {
                    if (!AllowChroma)
                    {
                        WriteTextSafe($"Map has a difficulty with Chroma, retrying.");
                        return RandomMap();
                    }
                }
                else
                {
                    if (OnlyChroma)
                    {
                        WriteTextSafe($"Map has no difficulties with Chroma, retrying.");
                        return RandomMap();
                    }
                }
                if (map.automapper) // Map is made with an automapper
                {
                    if (!AllowAutomapped)
                    {
                        WriteTextSafe($"Map is automapped, retrying.");
                        return RandomMap();
                    }
                }
                else // Map is not made with an automapper
                {
                    if (OnlyAutomapped)
                    {
                        WriteTextSafe($"Map is not automapped, retrying.");
                        return RandomMap();
                    }
                }
                return map;
            } else {
                WriteTextSafe($"Key is invalid, retrying.");
                return RandomMap();
            }    
            
        }
        private static int random(int max)
        {
            Random r = new Random();
            return r.Next(0, max);
        }
    }
    // Old doodoo api code
    /*class LatestBeatSaver
    {
        public Map[] docs { get; set; }
        public int totalDocs { get; set; }
        public int lastPage { get; set; }
        
        public int? prevPage { get; set; }
        public int? nextPage { get; set; }
    }
    class Map
    {
        public Metadata metadata { get; set; }
        public Stats stats { get; set; }
        public string description { get; set; }
        public string deletedAt { get; set; }
        public string _id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public Uploader uploader { get; set; }
        public string hash { get; set; }
        public string uploaded{ get; set; }
        public string directDownload { get; set; }
        public string downloadURL { get; set; }
        public string coverURL { get; set; }
    }
    class Uploader
    {
        public string _id { get; set; }
        public string name { get; set; }
    }
    class Stats
    {
        public int downloads { get; set; }
        public int plays { get; set; }
        public int downVotes { get; set; }
        public int upVotes { get; set; }
        public float heat { get; set; }
        public double rating { get; set; }
    }
    class Metadata
    {
        public Difficulties difficulties { get; set; }
        public float duration { get; set; }
        public string automapper { get; set; }
        public Characteristic[] characteristics { get; set; }
        public string levelAuthorName { get; set; }
        public string songAuthorName { get; set; }
        public string songName { get; set; }
        public string songSubName { get; set; }
        public float bpm { get; set; }
    }
    class Characteristic
    {
        public Difficultiestwo difficulties { get; set; }
        public string name { get; set; }
    }
    class Difficultiestwo
    {
        // this is a cardinal sin
        public Difficulty easy{ get; set; }
        public Difficulty normal{ get; set; }
        public Difficulty hard { get; set; }
        public Difficulty expert{ get; set; }
        public Difficulty expertPlus{ get; set; }
    }
    class Difficulty
    {
        public float duration { get; set; }
        public float length { get; set; }
        public float njs { get; set; }
        public float njsOffset { get; set; }
        public int bombs { get; set; }
        public int notes { get; set; }
        public int obstacles { get; set; }
    }
    class Difficulties
    {
        public bool easy { get; set; }
        public bool normal { get; set; }
        public bool hard { get; set; }
        public bool expert { get; set; }
        public bool expertPlus { get; set; }
    }*/
}
