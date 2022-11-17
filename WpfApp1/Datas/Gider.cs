using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Datas
{
    public class Gider
    {
        public string Urun_Adi { get; set; }
        public int Urun_Adet { get; set; }
        public decimal Urun_Adet_Fiyat { get; set; }

        public string Gider_Turu { get; set; }
        public decimal Toplam_Fiyat { get; set; }

        public override string ToString()
        {
            Toplam_Fiyat = Urun_Adet_Fiyat * Urun_Adet;
            //return $"{Urun_Adi} {Urun_Adet}x  {Toplam_Fiyat}₺ (Adet Fiyatı : {Urun_Adet_Fiyat}) Gider Türü : {Gider_Turu}";
            return $"{Urun_Adi} {Urun_Adet} {Toplam_Fiyat} {Urun_Adet_Fiyat} {Gider_Turu}";
        }
    }
}
