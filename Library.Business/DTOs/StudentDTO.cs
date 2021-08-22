using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.DTOs
{
   public class StudentDTO
    {
        public int Ogrno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime? Dtarih { get; set; }
        public string Cinsiyet { get; set; }
        public string Sinif { get; set; }
        public int? Puan { get; set; }
    }
}
