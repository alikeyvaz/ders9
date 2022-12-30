using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int FootCount { get; set; }

        public Animal(string name, int age,int weight, int footcount)
        {
            Name = name;
            Age = age;
            Weight = weight;
            FootCount = footcount;
        }
        public virtual string Showinfo()
        {
            return $"Heyvanin Adi: {Name}, Yasi: {Age}, Cekisi: {Weight}, AyaqSayi:{FootCount} ";
        }

    }
    class Sheep: Animal
    {
        public Sheep( string name, int age, int weight, int footcount) : base(name, age, weight, footcount)
        {
            Console.WriteLine("Sheep dolduruldu");
        }
    }
    class Cow:Animal
    {
        public double DailyMilk;
        public Cow(double dailymilk, string name, int age, int weight, int footcount) : base(name, age, weight, footcount)
        {
            DailyMilk = dailymilk;
        }
        public override string Showinfo()
        {
            return base.Showinfo() + $"Gundelik sud miqdari : {DailyMilk} ";
        }
    }
    class Farm
    {
        
        public void AddCow(Cow cow)
        {
            Array.Resize(ref Cows, Cows.Length + 1);
            Cows[Cows.Length - 1] = cow;
        }
        public void AddHorse(Hores horse)
        {
            Array.Resize(ref Horses, Horses.Length + 1);
            Horses[Horses.Length - 1] = horse;
        }
        public void AddSheep(Sheep sheep)
        {
            Array.Resize(ref Sheeps, Sheeps.Length + 1);
            Sheeps[Sheeps.Length - 1] = sheep;
        }
        
        public Sheep[] Sheeps = new Sheep[0];
        public Cow[] Cows = new Cow[0];
        public Hores[] Horses = new Horse[0];
        
    }
    class Hores:Animal
    {
        public float RunSpeed;
        public Hores(float runspeed, string name, int age, int weight, int footcount) :base(name, age, weight,footcount)
        {
            RunSpeed = runspeed;
        }
        public override string Showinfo()
        {
            return base.Showinfo() + $"Atin sureti : {RunSpeed} ";
        }
    }
}




// namespace ders9
// {
//     internal class Program
//     {
//         public static void Main(string[] args)
//         {
//            
//             
//             
//         }
//
//         class Animal
//         {
//             public static int ID;
//             public string Name;
//             public int Age;
//             public string Weight;
//             public int FootCount;
//             
//         }
//
//         class Sheep
//         {
//             public string Color;
//         }
//         
//     }
// }

//
//
// //Animal class
//Id olsun her heyvan yaradildiqda unique olsun.
//Name
//Age
//Weight
//FootCount
            
//Sheep class
//Color
            
//Cow class
//DailyMilk
            
//Horse class
//RunSpeed
            
//Farm class
//Sheeps
//Cows
//Horses
//AddCow()
//AddHorse()
//AddSheep()
//ShowAllAnimals() = butun heyvanlari gostersin;
//CountAnimalsByCategory() - bu method nece dene qoun varsa onun sayini, inek ve at larin sayini ayrica olaraq ve 
//elave olaraq sonda totalCount olaraq butun heyvanlarin sayini qaytarsin.