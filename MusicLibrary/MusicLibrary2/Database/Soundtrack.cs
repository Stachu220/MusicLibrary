using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary2.Database
{
    public class Soundtrack
    {
        public int ID { get; set; }
        public string Filename { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string Duration { get; set; }
        public string Tags { get; set; }
    }
}
