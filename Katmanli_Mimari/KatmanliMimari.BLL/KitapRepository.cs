using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.DAL;
using KatmanliMimari.DTO;
namespace KatmanliMimari.BLL
{
    public class KitapRepository
    {
        static KutuphaneDBEntities db = new KutuphaneDBEntities();

        public static List<KitapDataSourceDTO> dataSourceTumKitaplar()
        {
            var sonuc = db.Kitaplars.Select
                (
                    y => new KitapDataSourceDTO
                    {
                        KitapID = y.KitapId,
                        KitapAdi = y.KitapAdı
                    }
                ).ToList();

            return sonuc; 
        }

        public static List<KitapDTO> TumKitaplar()
        {
            var sonuc = db.Kitaplars.Select
                (
                    y => new KitapDTO
                    {
                        KitapID = y.KitapId,
                        KitapAd = y.KitapAdı,
                        KitapKonu = y.KitapKonusu,
                        YayinEv = y.Yayinevi,
                        YayinTarih = (DateTime)y.YayinTarihi,
                        YazarID = (int)y.YazarId
                    }
                ).ToList();

            return (List<KitapDTO>)sonuc;
        }

        // Kitap - Insert (Add) :

        public static bool KitapEkle(KitapDTO eklenenKitap)
        {
            bool sonuc = false;

            Kitaplar eklenecekKitap = new Kitaplar()
            {
                KitapAdı = eklenenKitap.KitapAd,
                KitapKonusu = eklenenKitap.KitapKonu,
                Yayinevi = eklenenKitap.YayinEv,
                YayinTarihi = Convert.ToDateTime(eklenenKitap.YayinTarih),
                YazarId = eklenenKitap.YazarID
            };

            db.Kitaplars.Add(eklenecekKitap);
            sonuc = db.SaveChanges() > 0;

            return sonuc;
        }
        // Kitap - Güncelle (Update) :

        public static bool KitapGuncelle(KitapDTO gelenKitap)
        {
            bool sonuc = false;

            Kitaplar guncellencekKitap = db.Kitaplars.Find(gelenKitap.KitapID);

            guncellencekKitap.KitapAdı = gelenKitap.KitapAd;
            guncellencekKitap.KitapKonusu = gelenKitap.KitapKonu;
            guncellencekKitap.Yayinevi = gelenKitap.YayinEv;
            guncellencekKitap.YayinTarihi = gelenKitap.YayinTarih;
            guncellencekKitap.YazarId = gelenKitap.YazarID;
            
             

            sonuc = db.SaveChanges() > 0;

            return sonuc;
        }

        // Kitap - Sil(Delete) :

        public static bool KitapSil(KitapDTO silinenKitap) 
        {

            Kitaplar silinecekKitap = db.Kitaplars.Find(silinenKitap.YazarID);
            db.Kitaplars.Remove(silinecekKitap);

            return db.SaveChanges() > 0;
        }

        public static KitapDTO IDyeGoreKitapGetir(int kitapID)
        {

            Kitaplar ArananKitap = db.Kitaplars.Find(kitapID); 

            KitapDTO yDTO = new KitapDTO()
            {    
                KitapAd = ArananKitap.KitapAdı,
                KitapKonu = ArananKitap.KitapKonusu,
                YayinEv = ArananKitap.Yayinevi,
                YayinTarih = Convert.ToDateTime(ArananKitap.YayinTarihi),
                YazarID = Convert.ToInt32(ArananKitap.YazarId)
            };
            return yDTO;
        }
    }
}
