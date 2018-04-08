using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseLogicalLayer
{
    public class DLL
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        int ReturnValues;
        DataTable dt;
        public DLL()
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString =" Data Source = DESKTOP-S18UU4V; Initial Catalog = Tarim; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        }
  
        public void BaglantiAyarla()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();
            else
                baglanti.Close();

        }

        public DataTable Listele()
        {
            try
            {
                BaglantiAyarla();
                komut = new SqlCommand("SP_Deneme_KayitListele", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(komut);
                dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception)
            {

                throw;
            }
            finally { BaglantiAyarla(); }
            
        }

        public int KayitEkle(Kayitlar K)
        {
            try
            {
                BaglantiAyarla();
                komut = new SqlCommand("SP_Deneme_KayitEkle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("@DosyaNumarasi", SqlDbType.Int).Value = K.DosyaNumarasi;
                komut.Parameters.Add("@Tc", SqlDbType.NVarChar).Value = K.Tc;
                komut.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = K.Isim;
                komut.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = K.Soyisim;
                komut.Parameters.Add("@Mahalle", SqlDbType.NVarChar).Value = K.Mahalle;
                komut.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = K.Aciklama;

                ReturnValues = komut.ExecuteNonQuery();
                return ReturnValues;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { BaglantiAyarla(); }
            return ReturnValues;

        }

        public int KayitDuzenle(Kayitlar K)
        {
            try
            {
                BaglantiAyarla();
                komut = new SqlCommand("SP_Deneme_KayitDuzenle", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("@DosyaNumarasi", SqlDbType.Int).Value = K.DosyaNumarasi;
                komut.Parameters.Add("@Tc", SqlDbType.NVarChar).Value = K.Tc;
                komut.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = K.Isim;
                komut.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = K.Soyisim;
                komut.Parameters.Add("@Mahalle", SqlDbType.NVarChar).Value = K.Mahalle;
                komut.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = K.Aciklama;
                komut.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = K.ID;


                ReturnValues = komut.ExecuteNonQuery();
                return ReturnValues;



            }
            catch (Exception)
            {

                throw;
            }
            finally { BaglantiAyarla(); }

        }

        public int KayitKayitSil(Kayitlar K)
        {
            try
            {
                BaglantiAyarla();
                komut = new SqlCommand("SP_Deneme_KayitSil", baglanti);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = K.ID;
                ReturnValues = komut.ExecuteNonQuery();
                return ReturnValues;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { BaglantiAyarla(); }
            return ReturnValues;

        }




    }
}
