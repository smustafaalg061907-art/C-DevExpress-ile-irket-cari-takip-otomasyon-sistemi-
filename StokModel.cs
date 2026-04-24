using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace StokProjesi.Models
{
    public class StokModel
    {
        public string StokKodu { get; set; } = string.Empty;
        public string StokAdi { get; set; } = string.Empty;
        public string Barkod { get; set; } = string.Empty;
        public string Birim { get; set; } = "ADET";
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int AlisKdv { get; set; } = 18;
        public int SatisKdv { get; set; } = 18;
        public string GrupKodu { get; set; } = string.Empty;

        public static List<StokModel> GetAll()
        {
            List<StokModel> liste = new List<StokModel>();
            try
            {
                DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Stoklar");
                foreach (DataRow dr in dt.Rows)
                {
                    liste.Add(new StokModel
                    {
                        StokKodu = dr["StokKodu"].ToString() ?? "",
                        StokAdi = dr["StokAdi"].ToString() ?? "",
                        Barkod = dr["Barkod"].ToString() ?? "",
                        Birim = dr["Birim"].ToString() ?? "ADET",
                        AlisFiyati = Convert.ToDecimal(dr["AlisFiyati"]),
                        SatisFiyati = Convert.ToDecimal(dr["SatisFiyati"]),
                        GrupKodu = dr["GrupKodu"].ToString() ?? ""
                    });
                }
            }
            catch { }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM Stoklar WHERE StokKodu = @StokKodu)
                            UPDATE Stoklar SET StokAdi=@StokAdi, Barkod=@Barkod, Birim=@Birim, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, GrupKodu=@GrupKodu WHERE StokKodu=@StokKodu
                            ELSE
                            INSERT INTO Stoklar (StokKodu, StokAdi, Barkod, Birim, AlisFiyati, SatisFiyati, GrupKodu) 
                            VALUES (@StokKodu, @StokAdi, @Barkod, @Birim, @AlisFiyati, @SatisFiyati, @GrupKodu)";
            
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@StokKodu", StokKodu),
                new SqlParameter("@StokAdi", StokAdi),
                new SqlParameter("@Barkod", Barkod),
                new SqlParameter("@Birim", Birim),
                new SqlParameter("@AlisFiyati", AlisFiyati),
                new SqlParameter("@SatisFiyati", SatisFiyati),
                new SqlParameter("@GrupKodu", string.IsNullOrEmpty(GrupKodu) ? (object)DBNull.Value : GrupKodu)
            ) > 0;
        }

        public static bool Delete(string stokKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM Stoklar WHERE StokKodu = @StokKodu", 
                new SqlParameter("@StokKodu", stokKodu)) > 0;
        }
    }

    public class StokGrupModel
    {
        public string GrupKodu { get; set; } = string.Empty;
        public string GrupAdi { get; set; } = string.Empty;

        public static List<StokGrupModel> GetAll()
        {
            List<StokGrupModel> liste = new List<StokGrupModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM StokGruplari");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new StokGrupModel { GrupKodu = dr["GrupKodu"].ToString() ?? "", GrupAdi = dr["GrupAdi"].ToString() ?? "" });
            }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM StokGruplari WHERE GrupKodu = @GrupKodu)
                            UPDATE StokGruplari SET GrupAdi=@GrupAdi WHERE GrupKodu=@GrupKodu
                            ELSE
                            INSERT INTO StokGruplari (GrupKodu, GrupAdi) VALUES (@GrupKodu, @GrupAdi)";
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@GrupKodu", GrupKodu),
                new SqlParameter("@GrupAdi", GrupAdi)) > 0;
        }

        public static bool Delete(string grupKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM StokGruplari WHERE GrupKodu = @GrupKodu",
                new SqlParameter("@GrupKodu", grupKodu)) > 0;
        }
    }

    public class CariModel
    {
        public string CariKodu { get; set; } = string.Empty;
        public string CariAdi { get; set; } = string.Empty;
        public string VergiDairesi { get; set; } = string.Empty;
        public string VergiNo { get; set; } = string.Empty;
        public string GrupKodu { get; set; } = string.Empty;

        public static List<CariModel> GetAll()
        {
            List<CariModel> liste = new List<CariModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Cariler");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new CariModel
                {
                    CariKodu = dr["CariKodu"].ToString() ?? "",
                    CariAdi = dr["CariAdi"].ToString() ?? "",
                    VergiDairesi = dr["VergiDairesi"].ToString() ?? "",
                    VergiNo = dr["VergiNo"].ToString() ?? "",
                    GrupKodu = dr["GrupKodu"].ToString() ?? ""
                });
            }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM Cariler WHERE CariKodu = @CariKodu)
                            UPDATE Cariler SET CariAdi=@CariAdi, VergiDairesi=@VergiDairesi, VergiNo=@VergiNo, GrupKodu=@GrupKodu WHERE CariKodu=@CariKodu
                            ELSE
                            INSERT INTO Cariler (CariKodu, CariAdi, VergiDairesi, VergiNo, GrupKodu) 
                            VALUES (@CariKodu, @CariAdi, @VergiDairesi, @VergiNo, @GrupKodu)";
            
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@CariKodu", CariKodu),
                new SqlParameter("@CariAdi", CariAdi),
                new SqlParameter("@VergiDairesi", VergiDairesi),
                new SqlParameter("@VergiNo", VergiNo),
                new SqlParameter("@GrupKodu", string.IsNullOrEmpty(GrupKodu) ? (object)DBNull.Value : GrupKodu)
            ) > 0;
        }

        public static bool Delete(string cariKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM Cariler WHERE CariKodu = @CariKodu", 
                new SqlParameter("@CariKodu", cariKodu)) > 0;
        }
    }

    public class CariGrupModel
    {
        public string GrupKodu { get; set; } = string.Empty;
        public string GrupAdi { get; set; } = string.Empty;

        public static List<CariGrupModel> GetAll()
        {
            List<CariGrupModel> liste = new List<CariGrupModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM CariGruplari");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new CariGrupModel { GrupKodu = dr["GrupKodu"].ToString() ?? "", GrupAdi = dr["GrupAdi"].ToString() ?? "" });
            }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM CariGruplari WHERE GrupKodu = @GrupKodu)
                            UPDATE CariGruplari SET GrupAdi=@GrupAdi WHERE GrupKodu=@GrupKodu
                            ELSE
                            INSERT INTO CariGruplari (GrupKodu, GrupAdi) VALUES (@GrupKodu, @GrupAdi)";
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@GrupKodu", GrupKodu),
                new SqlParameter("@GrupAdi", GrupAdi)) > 0;
        }

        public static bool Delete(string grupKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM CariGruplari WHERE GrupKodu = @GrupKodu",
                new SqlParameter("@GrupKodu", grupKodu)) > 0;
        }
    }

    public class BankaModel
    {
        public string BankaKodu { get; set; } = string.Empty;
        public string BankaAdi { get; set; } = string.Empty;
        public string SubeAdi { get; set; } = string.Empty;
        public string HesapNo { get; set; } = string.Empty;
        public string IBAN { get; set; } = string.Empty;

        public static List<BankaModel> GetAll()
        {
            List<BankaModel> liste = new List<BankaModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Bankalar");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new BankaModel
                {
                    BankaKodu = dr["BankaKodu"].ToString() ?? "",
                    BankaAdi = dr["BankaAdi"].ToString() ?? "",
                    SubeAdi = dr["SubeAdi"].ToString() ?? "",
                    HesapNo = dr["HesapNo"].ToString() ?? "",
                    IBAN = dr["IBAN"].ToString() ?? ""
                });
            }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM Bankalar WHERE BankaKodu = @BankaKodu)
                            UPDATE Bankalar SET BankaAdi=@BankaAdi, SubeAdi=@SubeAdi, HesapNo=@HesapNo, IBAN=@IBAN WHERE BankaKodu=@BankaKodu
                            ELSE
                            INSERT INTO Bankalar (BankaKodu, BankaAdi, SubeAdi, HesapNo, IBAN) 
                            VALUES (@BankaKodu, @BankaAdi, @SubeAdi, @HesapNo, @IBAN)";
            
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@BankaKodu", BankaKodu),
                new SqlParameter("@BankaAdi", BankaAdi),
                new SqlParameter("@SubeAdi", SubeAdi),
                new SqlParameter("@HesapNo", HesapNo),
                new SqlParameter("@IBAN", IBAN)
            ) > 0;
        }

        public static bool Delete(string bankaKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM Bankalar WHERE BankaKodu = @BankaKodu", 
                new SqlParameter("@BankaKodu", bankaKodu)) > 0;
        }
    }

    public class KasaModel
    {
        public string KasaKodu { get; set; } = string.Empty;
        public string KasaAdi { get; set; } = string.Empty;
        public decimal Bakiye { get; set; }

        public static List<KasaModel> GetAll()
        {
            List<KasaModel> liste = new List<KasaModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Kasalar");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new KasaModel
                {
                    KasaKodu = dr["KasaKodu"].ToString() ?? "",
                    KasaAdi = dr["KasaAdi"].ToString() ?? "",
                    Bakiye = Convert.ToDecimal(dr["Bakiye"])
                });
            }
            return liste;
        }

        public bool Save()
        {
            string query = @"IF EXISTS (SELECT 1 FROM Kasalar WHERE KasaKodu = @KasaKodu)
                            UPDATE Kasalar SET KasaAdi=@KasaAdi, Bakiye=@Bakiye WHERE KasaKodu=@KasaKodu
                            ELSE
                            INSERT INTO Kasalar (KasaKodu, KasaAdi, Bakiye) 
                            VALUES (@KasaKodu, @KasaAdi, @Bakiye)";
            
            return SqlHelper.ExecuteNonQuery(query,
                new SqlParameter("@KasaKodu", KasaKodu),
                new SqlParameter("@KasaAdi", KasaAdi),
                new SqlParameter("@Bakiye", Bakiye)
            ) > 0;
        }

        public static bool Delete(string kasaKodu)
        {
            return SqlHelper.ExecuteNonQuery("DELETE FROM Kasalar WHERE KasaKodu = @KasaKodu", 
                new SqlParameter("@KasaKodu", kasaKodu)) > 0;
        }
    }

    public class FaturaModel
    {
        public string FaturaNo { get; set; } = string.Empty;
        public string CariKodu { get; set; } = string.Empty;
        public DateTime Tarih { get; set; } = DateTime.Now;
        public decimal ToplamTutar { get; set; }

        public static List<FaturaModel> GetAll()
        {
            List<FaturaModel> liste = new List<FaturaModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Faturalar");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new FaturaModel
                {
                    FaturaNo = dr["FaturaNo"].ToString() ?? "",
                    CariKodu = dr["CariKodu"].ToString() ?? "",
                    Tarih = Convert.ToDateTime(dr["Tarih"]),
                    ToplamTutar = Convert.ToDecimal(dr["GenelToplam"])
                });
            }
            return liste;
        }
    }

    public class CekModel
    {
        public string CekNo { get; set; } = string.Empty;
        public string CariKodu { get; set; } = string.Empty;
        public DateTime VadeTarihi { get; set; } = DateTime.Now;
        public decimal Tutar { get; set; }
        public string BankaAdi { get; set; } = string.Empty;

        public static List<CekModel> GetAll()
        {
            List<CekModel> liste = new List<CekModel>();
            DataTable dt = SqlHelper.GetDataTable("SELECT * FROM Cekler");
            foreach (DataRow dr in dt.Rows)
            {
                liste.Add(new CekModel
                {
                    CekNo = dr["CekNo"].ToString() ?? "",
                    CariKodu = dr["CariKodu"].ToString() ?? "",
                    VadeTarihi = Convert.ToDateTime(dr["VadeTarihi"]),
                    Tutar = Convert.ToDecimal(dr["Tutar"]),
                    BankaAdi = dr["BankaAdi"].ToString() ?? ""
                });
            }
            return liste;
        }
    }

    public class HareketModel
    {
        public string Tip { get; set; } = string.Empty; // Stok, Cari, Kasa, Banka
        public string Kodu { get; set; } = string.Empty;
        public DateTime Tarih { get; set; } = DateTime.Now;
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; } = string.Empty;
    }

    public static class VeritabaniMock
    {
        public static List<StokModel> Stoklar => StokModel.GetAll();
        public static List<CariModel> Cariler => CariModel.GetAll();
        public static List<BankaModel> Bankalar => BankaModel.GetAll();
        public static List<KasaModel> Kasalar => KasaModel.GetAll();
        public static List<StokGrupModel> StokGruplari => StokGrupModel.GetAll();
        public static List<CariGrupModel> CariGruplari => CariGrupModel.GetAll();
        public static List<FaturaModel> Faturalar => FaturaModel.GetAll();
        public static List<CekModel> Cekler => CekModel.GetAll();
    }
}
