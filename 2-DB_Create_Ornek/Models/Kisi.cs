using System;
using System.Collections.Generic;

namespace _2_DB_Create_Ornek.Models
{
    public partial class Kisi
    {
        public int KisiId { get; set; }
        public string? KisiAd { get; set; }
        public string? KisiSoyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public string? Sehir { get; set; }
    }
}
