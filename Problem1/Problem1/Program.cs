using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            int op;
            while(true) 
            {    Console.Clear();
                op = menu();
                if (op == 1) 
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship Number: ");
                    string ship = Console.ReadLine();
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's degree :");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latituds's direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Angle angle = new Angle(degree, minutes, direction);
                    Console.WriteLine("Enter Ship Longtude: ");
                    Console.WriteLine("Enter Longitude's degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter longitude's direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Angle angle1 = new Angle(degree1, minutes1, direction1);
                    Ship ship1 = new Ship(ship,angle,angle1);
                    ships.Add(ship1);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();

                }
                else if (op == 2) 
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship Serial Number to find its position: ");
                    string serial = Console.ReadLine();
                    for(int i=0; i<ships.Count; i++) 
                    {
                        if (ships[i].serialNumber == serial) 
                        {
                            ships[i].printPosition();
                            break;
                        }
                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (op == 3) 
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Ship's Latitude: ");
                    string serial = Console.ReadLine();
                    Console.WriteLine("Enter the Ship's Longitude: ");
                    string serial1 = Console.ReadLine();
                    for(int i =0; i<ships.Count;i++) 
                    {
                        if (ships[i].Latitude.displayAngle()==serial && ships[i].Longitude.displayAngle()==serial1)
                        {
                            Console.WriteLine(ships[i].getSerial());
                            break;
                        }

                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if(op == 4) 
                {
                    Console.Clear();
                    Console.WriteLine("Enter the ship serial whose information you want to change: ");
                    string serial = Console.ReadLine();
                    for(int i=0; i<ships.Count;i++)
                    {
                        if (serial == ships[i].getSerial())
                        {
                            Console.WriteLine("Enter Ship Latitude: ");
                            Console.WriteLine("Enter Latitude's degree :");
                            int degree = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Latitude's minutes: ");
                            float minutes = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Latituds's direction: ");
                            char direction = char.Parse(Console.ReadLine());
                            Angle angle = new Angle(degree, minutes, direction);
                            Console.WriteLine("Enter Ship Longtude: ");
                            Console.WriteLine("Enter Longitude's degree: ");
                            int degree1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Longitude's minutes: ");
                            float minutes1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter longitude's direction: ");
                            char direction1 = char.Parse(Console.ReadLine());
                            Angle angle1 = new Angle(degree1, minutes1, direction1);
                            ships[i].Latitude.changeAngle(angle);
                            ships[i].Longitude.changeAngle(angle1);
                            Console.WriteLine("Press any key to continue: ");
                            Console.ReadKey();
                        }
                        
                    }
                }
                else if (op == 5)
                {
                    break;
                }

            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1.Add Ship: ");
            Console.WriteLine("2.View Ship Position: ");
            Console.WriteLine("3.View Ship Serial Number: ");
            Console.WriteLine("4.Change Ship Position: ");
            Console.WriteLine("5.Exit: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
