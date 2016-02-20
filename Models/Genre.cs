using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public int Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}