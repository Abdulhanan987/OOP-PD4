using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Player> player = new List<Player>();
            List <Stats> stats = new List<Stats>();
            int op;
            while (true) 
            {
                Console.Clear();
                op = menu();
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the player name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the playre health: ");
                    int health = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the player max Health: ");
                    int maxH = int.Parse(Console.ReadLine());
                    Console.WriteLine("Entet the player energy: ");
                    int energy = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the player max energy: ");
                    int maxe = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the player armor: ");
                    int armor = int.Parse(Console.ReadLine());
                    Player player1 = new Player(health, maxH, energy, maxe, armor, name);
                    player.Add(player1);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the skill name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the skill damage: ");
                    int damage = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the skill penetration: ");
                    float penetration = float.Parse(Console.ReadLine());
                    Console.WriteLine("Entre the skill cost: ");
                    int cost = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the skill heal : ");
                    float heal = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the skill description: ");
                    string description = Console.ReadLine();
                    Stats stats1 = new Stats(name, damage, description, penetration, cost, heal);
                    stats.Add(stats1);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    for (int i = 0; i < player.Count; i++)
                    {
                        Console.WriteLine("Name: {0},health: {1}/{2},armor : {3} ,energy{4}/{5}", player[i].name, player[i].hp, player[i].maxHp, player[i].armor, player[i].energy, player[i].maxEnergy);
                    }
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the player name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the skill name: ");
                    string skill = Console.ReadLine();
                    int playerindex = -1;
                    int skillindex = -1;
                    for (int i = 0; i < player.Count; i++)
                    {
                        if (name == player[i].name)
                        {
                            playerindex = i;
                        }
                    }
                    for (int i = 0; i < stats.Count; i++)
                    {
                        if (skill == stats[i].name)
                        {
                            skillindex = i;
                        }
                        

                    }
                    player[playerindex].learnSkills(stats[skillindex]);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (op == 5)
                {
                    Console.Clear();
                    for (int i = 0; i < player.Count; i++)
                    {
                        Console.WriteLine("Name: {0},health: {1}/{2},armor : {3} ,energy{4}/{5}", player[i].name, player[i].hp, player[i].maxHp, player[i].armor, player[i].energy, player[i].maxEnergy);
                    }
                    Console.WriteLine("Enter the attacker player ");
                    string name = Console.ReadLine();
                    int attacker = -1;
                    Console.WriteLine("Enter the player whom uoy want to attack: ");
                    for (int i = 0; i < player.Count; i++)
                    {
                        Console.WriteLine("Name: {0},health: {1}/{2},armor : {3} ,energy{4}/{5}", player[i].name, player[i].hp, player[i].maxHp, player[i].armor, player[i].energy, player[i].maxEnergy);
                    }
                    string name1 = Console.ReadLine();
                    int defender = -1;
                    for (int i = 0; i < player.Count; i++)
                    {
                        if (name == player[i].name)
                        {
                            attacker = i;
                        }
                    }
                    for (int i = 0; i < player.Count; i++)
                    {
                        if (name1 == player[i].name)
                        {
                            defender = i;
                        }
                    }
                    Console.WriteLine(player[attacker].attack(player[defender]));
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();

                }
                else if (op == 6)
                    break;
            }

        }
        static int menu()
        {
            int op;
            Console.WriteLine("1.Add Player: ");
            Console.WriteLine("2.Add Statistics: ");
            Console.WriteLine("3.Display player info: ");
            Console.WriteLine("4.Learn a skill: ");
            Console.WriteLine("5.Attack: ");
            Console.WriteLine("6.Exit: ");
            op=int.Parse(Console.ReadLine());
            return op;

        }
    }
}
