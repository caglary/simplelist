using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kayitlar
    {
        public Guid ID { get; set; }
        public int DosyaNumarasi { get; set; }
        public string Tc { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Mahalle { get; set; }
        public string Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
