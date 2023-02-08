using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_sales.Models.Ticketsale
{
    internal class Train
    {
        List<Van> vanCollection;
        private int trainLength = 0;
        public int TrainLength
        {
            get {return trainLength;}
        }

        //наличие свободных мест в вагоне
        public bool FreePlace(int placeVagon, int placePosition)
        {
            return vanCollection[placeVagon].FreePlace(placePosition);
        }
        //заполняет место для пассажира
        public void OnPlace(int placeVagon, int placePosition, string passanger)
        {
            vanCollection[placeVagon].OnPlace(placePosition, passanger);
        }
    }

    class PlaceInTheTrain //новое место для пассажира
    {
        int place;
        public string Passenger { get; set; }
        public PlaceInTheTrain()
        {
            place = 0;
            Passenger = String.Empty;
        }
    }

    class Van
    {
        PlaceInTheTrain[] places;
        private const int placesInTrain = 40;// макс.количество 

        public bool FreePlace(int numberPlace)
        {
            return places[numberPlace].Passenger == String.Empty;
        }

        public void OnPlace(int numberPlace, string passanger)
        {
            places[numberPlace].Passenger = passanger;
        }

    }
    
    class Program
    {
        static Train train;
        private static int numberTrain = 0;
        private static int numberPlace = 0;
        private static string passangerName = default;
        

        static void Main(string[] args)
        {
            string chooseTrain = default;
            Console.WriteLine("Выберите поезд из списка ниже:\n");
            Console.WriteLine(@"Поезд 'Москва-Казань' нажмите ""1""");
            Console.WriteLine(@"Поезд 'Москва-Анапа' нажмите ""2""");
            Console.WriteLine(@"Поезд 'Москва-Симферополь' нажмите ""3""");
            chooseTrain = Console.ReadLine();
            switch (chooseTrain)
            {
                case "1":
                    {
                        Console.WriteLine("Выбран поезд 'Москва-Казань'\n");
                        
                        do
                        {
                            EnterData();
                        } while (passangerName != String.Empty);
                        break;
                    }
                case "2":
                
                    {
                        Console.WriteLine("Выбран поезд 'Москва — Анапа'\n");
                        
                        do
                        {
                            EnterData();
                        } while (passangerName != String.Empty);
                        break;
                    }
                case "3":
                
                    {
                        Console.WriteLine("Выбран поезд 'Москва — Симферополь'\n");
                        
                        do
                        {
                            EnterData();
                        } while (passangerName!= String.Empty);
                        break;
                    }
            }
            Console.ReadKey();
        }
        
        public static void EnterData()
        {
            Console.WriteLine("Укажите номер поезда");
            numberTrain = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите свободное место");
            numberPlace = Convert.ToInt32(Console.ReadLine());
            if (train.FreePlace(numberTrain, numberPlace))
            {
                Console.WriteLine("Введите ФИО ");
                passangerName = Console.ReadLine();
                train.OnPlace(numberTrain,numberPlace,passangerName);
                Console.WriteLine("Пассажир успешно добавлен!"); 
            }
        }
    }
}
