using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
    }
}
