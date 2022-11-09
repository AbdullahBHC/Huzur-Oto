using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WpfApp1.Datas
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public List<string> Boyanan_Parcalar = new List<string>();
        public List<string> Değişen_Parcalar = new List<string>();
        public decimal Toplam_Tutar { get; set; }
        public BitmapImage Resim { get; set; }

        public bool Kaskodan_Mi_Yapildi { get; set; }
        public bool Elden_Mi_Yapildi { get; set; }

        public override string ToString()
        {
            var boyanan = String.Join(" , ", Boyanan_Parcalar.ToArray());
            var degisen = String.Join(" , ", Değişen_Parcalar.ToArray());
            var sonuc ="";
            var kasko = Kaskodan_Mi_Yapildi;
            if (Kaskodan_Mi_Yapildi==false)
            {
                if (Boyanan_Parcalar.Count == 0 && Değişen_Parcalar.Count == 0)
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boya Yok. ~ {degisen} Değişen Yok. ↬ Elden Yapıldı.";
                else if (Değişen_Parcalar.Count == 0)
                {
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boyandı. ~ {degisen} Değişen Yok. ↬ Elden Yapıldı.";
                }
                else if (Boyanan_Parcalar.Count == 0)
                {
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boya Yok. ~ {degisen} Değişti. ↬ Elden Yapıldı.";
                }
                else
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boyandı. ~ {degisen} Değişti. ↬ Elden Yapıldı.";
            }
            else
            {
                if (Boyanan_Parcalar.Count == 0 && Değişen_Parcalar.Count == 0)
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boya Yok. ~ {degisen} Değişen Yok. ↬ Kaskodan Yapıldı.";
                else if (Değişen_Parcalar.Count == 0)
                {
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boyandı. ~ {degisen} Değişen Yok. ↬ Kaskodan Yapıldı.";
                }
                else if (Boyanan_Parcalar.Count == 0)
                {
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boya Yok. ~ {degisen} Değişti. ↬ Kaskodan Yapıldı.";
                }
                else
                    return sonuc = $"{Marka} {Model} - {Yil} | {boyanan} Boyandı. ~ {degisen} Değişti. ↬ Kaskodan Yapıldı.";
            }
        }
    }
}
