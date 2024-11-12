using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230066
{
    // Abstraction: Membuat kelas dasar Anime dengan beberapa property dan method dasar
    internal abstract class Anime_714230066
    {
        // Encapsulation: Menggunakan property untuk melindungi field privat
        public string Title { get; set; }
        public string Genre { get; set; }

        // Constructor untuk menginisialisasi properti
        public Anime_714230066(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }

        // Method abstrak untuk diturunkan ke kelas turunan
        public abstract void Play();
    }

    // Inheritance: Kelas turunan dari Anime_714230066
    internal class ActionAnime : Anime_714230066
    {
        public string HeroName { get; set; }

        // Constructor untuk menginisialisasi properti kelas turunan
        public ActionAnime(string title, string genre, string heroName)
            : base(title, genre)
        {
            HeroName = heroName;
        }

        // Polymorphism: Implementasi berbeda dari method Play()
        public override void Play()
        {
            Console.WriteLine($"Now playing action anime: {Title} - Genre: {Genre}");
            Console.WriteLine($"Hero: {HeroName} is fighting!");
        }
    }

    internal class RomanceAnime : Anime_714230066
    {
        public string MainCouple { get; set; }

        // Constructor untuk menginisialisasi properti kelas turunan
        public RomanceAnime(string title, string genre, string mainCouple)
            : base(title, genre)
        {
            MainCouple = mainCouple;
        }

        // Polymorphism: Implementasi berbeda dari method Play()
        public override void Play()
        {
            Console.WriteLine($"Now playing romance anime: {Title} - Genre: {Genre}");
            Console.WriteLine($"Main couple: {MainCouple} is going through ups and downs!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Membuat daftar anime
            List<Anime_714230066> animeList = new List<Anime_714230066>
            {
                new ActionAnime("Attack on Titan", "Action", "Eren Yeager"),
                new RomanceAnime("Your Name", "Romance", "Taki and Mitsuha")
            };

            // Memutar setiap anime dalam daftar
            foreach (var anime in animeList)
            {
                anime.Play();
                Console.WriteLine();
            }
        }
    }
}
