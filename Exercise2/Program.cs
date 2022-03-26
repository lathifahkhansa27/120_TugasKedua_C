using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InseretData();
        }
        public void InseretData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=lathifah;database=TOKOROTILIA;User ID=sa;Password=kimtaehyung");
                con.Open();

                SqlCommand cm = new SqlCommand(
                    "insert into barang (id_barang, nama_barang, harga) values('011234','Black Forest','20.000')" +
                    "insert into barang(id_barang, nama_barang, harga) values('011235','Red Velvet','22.000')" +
                    "insert into barang(id_barang, nama_barang, harga) values('0112346','Chess Cake','25.000')" +
                     "insert into barang(id_barang, nama_barang, harga) values('011237','Tiramizu','20.000')" +
                     "insert into barang(id_barang, nama_barang, harga) values('001238','Strowberry Cake','25.000')" +


                    " insert into pembeli (id_pembeli, nama, alamat, no_telpon) values('12','Lisa','Thailand','012345')" +
                     "insert into pembeli(id_pembeli, nama, alamat, no_telpon) values('13','Jennie','Seoul','01234564')" +
                    "insert into pembeli(id_pembeli, nama, alamat, no_telpon) values('15','Rose','Gangnam','0963728134')" +
                    "insert into pembeli(id_pembeli, nama, alamat, no_telpon) values('11','Jiso','Paris','098272664')" +
                    "insert into pembeli(id_pembeli, nama, alamat, no_telpon) values('17','Wendy','Busan','09282913')" +

                    "insert into karyawan (id_karyawan, nama_karyawan) values('1','Nouval')" +
                    "insert into karyawan(id_karyawan, nama_karyawan) values('2','Ilham')" +
                    "insert into karyawan(id_karyawan, nama_karyawan) values('3','Jimin')" +
                    "insert into karyawan(id_karyawan, nama_karyawan) values('4','Jake')" +
                    "insert into karyawan(id_karyawan, nama_karyawan) values('5','Jhope')" +


                "insert into transaksi(id_transaksi, id_barang, id_karyawan, id_pembeli, tanggal, jumlah_harga, qty) values('01','011234','1','12','03032022','40.000','2')" +
                   "insert into transaksi(id_transaksi, id_barang, id_karyawan, id_pembeli, tanggal, jumlah_harga, qty) values('2','011235','2','13','27022022','22.000','1')" +
                   "insert into transaksi(id_transaksi, id_barang, id_karyawan, id_pembeli, tanggal, jumlah_harga, qty) values ('3','0112346','3','15','2012022','50.000','2')" +
                   "insert into transaksi(id_transaksi, id_barang, id_karyawan, id_pembeli, tanggal, jumlah_harga, qty) values ('4','011237','4','11','15032022','60.000','3')" +
                    "insert into transaksi(id_transaksi, id_barang, id_karyawan, id_pembeli, tanggal, jumlah_harga, qty) values('5','001238','5','17','1032022','75.000','3')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("sukses menambahkan data");
                Console.ReadKey();
          
            } catch(Exception e)
            {
                Console.WriteLine("gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
