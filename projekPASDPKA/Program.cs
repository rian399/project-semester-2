using System;
using System.Collections.Generic;

class projekpasdpka
{
    static void Main(string[] args)
    {
        Console.Clear();
        int noekskul;
        string cont;
        string s, namaSiswa = "";
        Console.WriteLine("Selamat Datang di Program Pemilihan Ekskul");
        Console.Write("Masukkan Nama Siswa : ");
        List<string> data = new List<string>();
        s = Console.ReadLine();
        while (true)
        {
            Console.WriteLine($"Pilih ekskul yang diikuti oleh {s} ");
            Console.WriteLine("1. Basket");
            Console.WriteLine("2. Futsal");
            Console.WriteLine("3. Matematika");
            Console.WriteLine("4. Photography");
            Console.WriteLine("5. Web Technology");
            Console.WriteLine("6. Bahasa Inggris");
            Console.WriteLine("7. Badminton");

            Console.Write("Masukkan nomor ekskul pilihan : ");
            int pilihanEkskul;
            if (int.TryParse(Console.ReadLine(), out pilihanEkskul))
            {
                switch (pilihanEkskul)
                {
                    case 1:
                        Console.WriteLine(s + " akan mengikuti ekskul basket. ");
                        data.Add("basket");
                        break;
                    case 2:
                        Console.WriteLine(s + " akan mengikuti ekskul futsal. ");
                        data.Add("futsal");
                        break;
                    case 3:
                        Console.WriteLine(s + " akan mengikuti ekskul matematika. ");
                        data.Add("matematika");
                        break;
                    case 4:
                        Console.WriteLine(s + " akan mengikuti ekskul photography. ");
                        data.Add("photography");
                        break;
                    case 5:
                        Console.WriteLine(s + " akan mengikuti ekskul Web technology. ");
                        data.Add("web technology");
                        break;
                    case 6:
                        Console.WriteLine(s + " akan mengikuti ekskul Bahasa inggris. ");
                        data.Add("bahasa inggris");
                        break;
                    case 7:
                        Console.WriteLine(s + " akan mengikuti ekskul badminton. ");
                        data.Add("badminton");
                        break;
                    default:
                        Console.WriteLine("Masukkan tidak valid. Mohon masukkan nomor ekskul dengan benar.");
                        continue;
                }
            }

            Console.Write("Apakah anda ingin mengikuti ekskul lainnya (ya/tidak)? ");
            cont = Console.ReadLine().ToLower();
            if (cont == "ya")
            {
                continue;
            }
            else if (cont == "tidak")
            {
                Console.WriteLine($"{s} telah mengikuti ekskul {string.Join(" dan ", data)}. Terimakasih telah mengikuti program pemilihan ekskul.");
                break;
            }
        }
        Console.ReadKey();    }
}
