using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Men.Utilities
{
    public static class Filters
    {

        public static short filter = 0b000001110;

        
    }
    public static class FilterBits
    {
        public static short AllowAutomapped = 0b0000000001;
        public static short AllowNoodleExtensions = 0b0000000010;
        public static short AllowMappingExtensions = 0b0000000100;
        public static short AllowChroma = 0b0000001000;
        public static short AllowCinema = 0b0000010000;
        public static short OnlyAutomapped = 0b0000100000;
        public static short OnlyNoodleExtensions = 0b0001000000;
        public static short OnlyMappingExtensions = 0b0010000000;
        public static short OnlyChroma = 0b0100000000;
        public static short OnlyCinema = 0b1000000000;

    }
}   
