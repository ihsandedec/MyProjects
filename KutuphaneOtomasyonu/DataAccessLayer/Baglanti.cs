using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class Baglanti
    {
        //bağlantı nesnesi oluşturma ve sql string'i ile databse bağlantısı oluşturma 
        public static OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DEDEC\Desktop\Projeİhsan\KutuphaneOtomasyonu\KutuphaneOtomasyonu\bin\Debug\DataAccess.mdb");
    }
}
