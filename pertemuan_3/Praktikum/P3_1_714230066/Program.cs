namespace P3_1_714230066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Menentukan Indeks Prestasi Mahasiswa\n----------");
                Console.Write("\nmasukan Nama Mahasiswa: ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukan NIlai : ");
                int nilai = Convert.ToInt16(Console.ReadLine());
                string[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("index nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("index nilai {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("index nilai {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("index nilai {0} adalah {1}", nama, grade[3]);
                }

                Console.Write("\nMasukan Index Yang Ingin Ditampilkan: ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks Prestasi {0} adalah", nama);

                prestasi(indeks);

                Console.Write("\nIngin Mengulang Kembali (Y/T): ");
            }
            while (Console.ReadLine() == "Y");
        }

        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("SANGAT BAIK");
                    break;
                case 'B':
                    Console.WriteLine("BAIK");
                    break;
                case 'C':
                    Console.WriteLine("CUKUP");
                    break;
                case 'D':
                    Console.WriteLine("BURUK");
                    break;
                default:
                    Console.WriteLine("INVALID INDEKS PRESTASI");
                    break;
            }
        }
    }
    
}
