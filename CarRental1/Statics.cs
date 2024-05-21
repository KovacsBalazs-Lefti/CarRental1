
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental1
{
    internal static class Statics
    {
        static List<Car> cars;

        public static void Run()
        {
            try
            {
                ReadAllCars();
                Console.WriteLine("20.000 Ft-nál olcsóbb napidíjú autók száma: {0}", CountCheaperThan20000Ft());
                Console.WriteLine("{0} az adatok között 26.000 Ft-nál drágább napidíjú autó", MoreExpensivethan26000() ? "Van" : "Nincs");
                Car mostexpensive = GetmostexpensiveCar();
                Console.WriteLine(" A legdrágább napidíjú autó:" +
                    "\r\n\t Rendszám: {0}" +
                    "\r\n\t Márka: {1}" +
                    "\r\n\t Model: {2}" +
                    "\r\n\t Napidíj: {3}", mostexpensive.License_plate_number, mostexpensive.Brand, mostexpensive.Model, mostexpensive.Daily_cost);

                Console.WriteLine("Az autó típusa és darabszámai: ");
                Console.WriteLine(getcarquantity());
                Console.WriteLine("Adjon meg egy rendszámot: ");
                string license_plate_number = Console.ReadLine();
                printLicensePlateNumber(license_plate_number);
                //cars.ForEach(car => Console.WriteLine(car.License_plate_number));
                Console.ReadKey();

            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Hiba történt az adatbázis kapcsolat kiépítésekor: ");
                Console.WriteLine(ex.Message);

                Console.ReadKey();

            }
        }

        private static void printLicensePlateNumber(string license_plate_number)
        {
            int index = 0;
            while (index < cars.Count && cars[index].License_plate_number != license_plate_number)
            {
                index++;
            }
            if (index < cars.Count)
            {
                Console.WriteLine("A megadott rendszám: {0}", cars[index].License_plate_number);
                //Console.WriteLine("A megadott autó napidíja: {0}", cars[index].Daily_cost);

                if (cars[index].Daily_cost > 25000)
                {
                    Console.WriteLine("Ez az autó napidíja nagyobb, mint 25000.");
                }
                else
                {
                    Console.WriteLine("Ez az autó napidíja nem nagyobb, mint 25000.");
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen autó");
            }
        }

        private static string getcarquantity()
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, int>brandCarcount = new Dictionary<string, int>();
            foreach (Car car in cars)
            {
                if (!brandCarcount.ContainsKey(car.Brand))
                {
                    brandCarcount[car.Brand] = 0;
                }
                brandCarcount[car.Brand]++;
            }
            foreach (var entry in brandCarcount)
            {
                sb.AppendLine($"Autó típusa: {entry.Key} = {entry.Value} db");
            }

            return sb.ToString();
        }

        private static Car GetmostexpensiveCar()
        {
            Car mostexpensive = cars[0];
            for (int i = 1; i < cars.Count; i++)
            {
                if (cars[i].Daily_cost>mostexpensive.Daily_cost)
                {
                    mostexpensive = cars[i];

                }
            }
            return mostexpensive;
        }

        private static bool MoreExpensivethan26000()
        {
           int index = 0;
            while(index < cars.Count && !(cars[index].Daily_cost > 26000))
            {
                index++;
            }
            return index < cars.Count;
        }

        private static int CountCheaperThan20000Ft()
        {
           int count = 0;
            foreach (Car car in cars)
            {
                if (car.Daily_cost < 20000)
                {
                    count++;
                }
            }
            return count;
        }

        private static void ReadAllCars()
        {
            CarService carService = new CarService();
            cars = carService.GetCars();

        }
    }
}
