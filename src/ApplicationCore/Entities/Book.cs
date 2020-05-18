using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }

    }
}
