using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Datas
{
    public class Kasko
    {
        public string Sigorta_Sirketi { get; set; }
        public string Dosya_No { get; set; }
        public string Police_No { get; set; }
        public string Arac_Sahibi { get; set; }
        public string Telefon_No { get; set; }
        public string Plaka { get; set; }
        public string Tc_No { get; set; }
        public string Belge_Seri_No { get; set; }

        public DateTime Kaza_Tarihi { get; set; }
        public string Kaza_Adresi { get; set; }
        public string Vuran_Surucu { get; set; }
        public string Vuran_Tc { get; set; }
        public string Vuran_Telefon_No { get; set; }
        public string Eksper_Adi { get; set; }
        public string Eksper_Telefon_No { get; set; }
        public override string ToString() => $"{Sigorta_Sirketi} {Dosya_No} {Police_No} {Arac_Sahibi} {Telefon_No} {Plaka} {Tc_No} {Belge_Seri_No} {Kaza_Tarihi} {Kaza_Adresi} {Vuran_Surucu} {Vuran_Tc} {Vuran_Telefon_No} {Eksper_Adi} {Eksper_Telefon_No}";


    }
}
