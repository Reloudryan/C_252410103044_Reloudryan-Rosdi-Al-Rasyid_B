using System.ComponentModel;

namespace C_252410103044_Reloudryan_Rosdi_Al_Rasyid_B
{

    public class Agen
    {
        public string idAgen { get; set; }
        public string NamaAgen { get; set; }
        public int StokAgen { get; set; }


        public void TampilInfo()
        {
            Console.WriteLine($"id Agen : {idAgen}");
            Console.WriteLine($"Nama Agen: {NamaAgen}");
            Console.WriteLine($"Jumlah Stok Agen: {StokAgen}");
        }

        public class ProdukGalon
        {
            private string idProduk { get; set; }
            private string NamaProduk { get; set; }
            private int StokGudang { get; set; }

        }

        public void KurangiStok(int jumlah)
        {
            if (jumlah == 0)

                Console.WriteLine($"Stok Berhasil dikurangi");

            else (jumlah < 0)


                Console.WriteLine($"Stok Tidak Boleh kurang dari 0!");


        }

        public class GalonAkua : ProdukGalon
        {
            public int hargaGalonAkua = 20000;
        }
        public class GalonKeran : ProdukGalon
        {
            public int hargaGalonKeran = 12000;

        }

        public virtual void HitungBiaya(int jumlah)
        {
            HitungBiaya(jumlah * 20000);
            HitungBiaya(jumlah * 12000);
        }

        public interface DapatDidistribusikan
        {
            public class DistribusiGalon
            {
                public string agentujuan { get; set; }
                public string produkgalon { get; set; }
                public int jumlahgalon { get; set; }
            }
        }

        public class SindikatGalon
        {
            List<Agen> daftarAgen = new List<Agen>();
            List<ProdukGalon> daftarProduk = new List<ProdukGalon>();

            public void TampilkanSindikat()
            {
                Console.WriteLine($"Agen: {daftarAgen}");
                Console.WriteLine($"Produk Galon: {daftarProduk}");
            }

        }
    }
}

//Hubungan antara Class Sindikat Galon dan class Agen yaitu didalam class Sindikat Galon memuat data Agen Galon yang termuat didalam class Agen, sehingga kedua class ini saling berhubungan



