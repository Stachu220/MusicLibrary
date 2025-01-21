using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Database
{
    public class Soundtrack
    {
        public int ID { get; set; }
        public string Filename { get; set; }
        public string DisplayName { get; set; }
        public int CategoryID { get; set; }
        public string Duration { get; set; }
        public DateTime DateAdded { get; set; }
        public string Tags { get; set; }
        public string FileFormat { get; set; }
    }
}
