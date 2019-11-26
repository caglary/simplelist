using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class BLL
    {
        DatabaseLogicalLayer.DLL dll; 
        public BLL()
        {
            dll= new DatabaseLogicalLayer.DLL();
        }
        DataTable dt;
        int ReturnValues;
      
        public DataTable Listele()
        {
            dll = new DatabaseLogicalLayer.DLL();
            dt=dll.Listele();

            return dt;
          
        }

        public int KayitEkle(Kayitlar K)
        {

            ReturnValues = dll.KayitEkle(K);
            return ReturnValues;

        }
        public int KayitDuzenle(Kayitlar K)
        {
            ReturnValues = dll.KayitDuzenle(K);
            return ReturnValues;

        }
        public int KayitSil(Kayitlar K)
        {
            ReturnValues = dll.KayitKayitSil(K);
            return ReturnValues;

        }

    }
}
