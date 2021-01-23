using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Img { get; set; }
        public string Bilgi { get; set; }
    }
}
