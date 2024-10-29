using System;

namespace P3_2_714230066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string repeat = "Y"; // Initialize repeat to avoid unassigned variable error

            do
            {
                // Display menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Hitung Luas Persegi Panjang");
                Console.WriteLine("2. Hitung Keliling Persegi Panjang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                // Read choice and parse it to an integer
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih menu 1, 2, atau 3.");
                    continue;
                }

                // Handle menu options
                switch (choice)
                {
                    case 1:
                        CalculateArea();
                        break;
                    case 2:
                        CalculatePerimeter();
                        break;
                    case 3:
                        Console.WriteLine("Program berhenti.");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan pilih menu 1, 2, atau 3.");
                        break;
                }

                // Ask if user wants to repeat or return to menu
                Console.Write("Apakah Anda ingin mengulang? (Y untuk kembali ke menu, T untuk berhenti): ");
                repeat = Console.ReadLine()?.ToUpper() ?? "T"; // Ensure repeat is not null

            } while (repeat == "Y");

            Console.WriteLine("Program selesai.");
        }

        static void CalculateArea()
        {
            // Input length and width
            Console.Write("Masukkan panjang: ");
            if (!float.TryParse(Console.ReadLine(), out float length))
            {
                Console.WriteLine("Input tidak valid untuk panjang.");
                return;
            }

            Console.Write("Masukkan lebar: ");
            if (!float.TryParse(Console.ReadLine(), out float width))
            {
                Console.WriteLine("Input tidak valid untuk lebar.");
                return;
            }

            // Calculate area
            float area = length * width;

            // Display result
            Console.WriteLine($"Luas persegi panjang: {area:F2}");
        }

        static void CalculatePerimeter()
        {
            // Input length and width
            Console.Write("Masukkan panjang: ");
            if (!float.TryParse(Console.ReadLine(), out float length))
            {
                Console.WriteLine("Input tidak valid untuk panjang.");
                return;
            }

            Console.Write("Masukkan lebar: ");
            if (!float.TryParse(Console.ReadLine(), out float width))
            {
                Console.WriteLine("Input tidak valid untuk lebar.");
                return;
            }

            // Calculate perimeter
            float perimeter = 2 * (length + width);

            // Display result
            Console.WriteLine($"Keliling persegi panjang: {perimeter:F2}");
        }
    }
}
