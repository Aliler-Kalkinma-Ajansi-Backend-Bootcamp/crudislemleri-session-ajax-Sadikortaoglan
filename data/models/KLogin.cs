using System;
using System.Collections.Generic;

#nullable disable

namespace data.Models
{
    public partial class KLogin
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
