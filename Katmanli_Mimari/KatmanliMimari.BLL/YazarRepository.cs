using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------
using KatmanliMimari.DAL;
using KatmanliMimari.DTO;
namespace KatmanliMimari.BLL
{ //tüm yapının controller katmanı
    public class YazarRepository
    {
        static KutuphaneDBEntities db = new KutuphaneDBEntities();

        public static List<YazarDataSourceDTO> dataSourceTumYazarlar()
        {
            var sonuc = db.Yazarlars.Select
                (
                    y => new YazarDataSourceDTO
                    {
                        YazarID = y.YazarId,
                        AdiSoyadi = y.YazarAd + " " + y.YazarSoyad
                    }
                ).ToList();

            return sonuc; //veya (List<YazarDAtaSourceDTO>)return sonuc; 
        }

        public static List<YazarDTO> TumYazarlar()
        {
            var sonuc = db.Yazarlars.Select
                (
                    y => new YazarDTO
                    {
                        YazarID = y.YazarId,
                        YazarAd = y.YazarAd,
                        YazarSoyad = y.YazarSoyad,
                        Ozgecmis = y.Ozgecmis

                    }
                ).ToList();

            return (List<YazarDTO>)sonuc;
        }

        //----------------------------------------------
        

        // Yazar - Insert (Add) metodumuz :

        public static bool YazarEkle(YazarDTO eklenenYazar)
        {
            bool sonuc = false;

            Yazarlar eklenecekYazar = new Yazarlar()
            {
                YazarAd = eklenenYazar.YazarAd,
                YazarSoyad = eklenenYazar.YazarSoyad,
                Ozgecmis = eklenenYazar.Ozgecmis
            };

            db.Yazarlars.Add(eklenecekYazar);
            sonuc = db.SaveChanges() > 0;

            return sonuc;
        }

        // Yazar - Güncelle(Update) metodumuz :

        public static bool YazarGuncelle(YazarDTO gelenYazar)
        {
            bool sonuc = false;

            Yazarlar guncellencekYazar = db.Yazarlars.Find(gelenYazar.YazarID);

            guncellencekYazar.YazarAd = gelenYazar.YazarAd;
            guncellencekYazar.YazarSoyad = gelenYazar.YazarSoyad;
            guncellencekYazar.Ozgecmis = gelenYazar.Ozgecmis;
           
            sonuc = db.SaveChanges() > 0;

            return sonuc;
        }

        // Yazar - Sil(Delete) metodumuz :

        public static bool YazarSil(YazarDTO silinenYazar) 
        {
           
            Yazarlar silinecekYazar = db.Yazarlars.Find(silinenYazar.YazarID); 
            db.Yazarlars.Remove(silinecekYazar);
            
            return db.SaveChanges() > 0;
        }

        // Yazar - List(Select) -> ID'ye göre arama metodumuz :

        public static YazarDTO IDyeGoreYazarGetir(int yazarID) // veya int Id
        {

            Yazarlar ArananYazar = db.Yazarlars.Find(yazarID); //veya .find(id)

            YazarDTO yDTO = new YazarDTO()
            {
                YazarID = ArananYazar.YazarId,
                YazarAd = ArananYazar.YazarAd,
                YazarSoyad = ArananYazar.YazarSoyad,
                Ozgecmis = ArananYazar.Ozgecmis
            };
            return yDTO;
        }
    }
}
