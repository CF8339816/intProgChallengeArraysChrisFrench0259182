using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progSep17ArraysChrisFrench0259182
{
    //code by written by  Chris French 0259812
    //references used:
    //https://www.youtube.com/watch?v=hpaH6eoKKcI&list=PLdYuBFQaeYTs460QSUVj11nPQslGyzeMX
    //https://www.youtube.com/watch?v=N1YxtK2YrAw
    //arrays
    internal class Program
    {

        //static values


        static string[] weaponTypes = { "automatic pistol", "sniper rifle", "machine gun", "rocket launcher" };
        static int[] ammoCount = new int[4];
        static int[] weaponDamage = { 15, 50, 35, 100 };
        static int[] fireRate= { 2, 1, 5, 1 };
        //  static int weapon = 0;        // Weapon selected
        static int enemyHealth = 100;  // Enemy health
        // static int health = 100;   // Player Health
        // static int mgunDmg = 25;     // Machine gun damage
        // static int pisDmg = 15;   //Pistol damage
        // static int rlDmg = 100;    //Rocket Launcher damage
        // static int snpDmg = 50;    //Sniper Rifle damage
       




        static void Main(string[] args)
        {

            hud();

            Console.WriteLine($"You have  encountered an enemy. Enemy health is {enemyHealth}. ");

            weaponSelector();



            // ammoCount[0] = 14;
            // ammoCount[1] = 5;
            // ammoCount[2] = 50;
            // ammoCount[3] = 4;

            // Console.ReadKey();

            /*
            Console.WriteLine("Press r to reload your weapon");

            if (Console.ReadKey()) == "r";
            {
                reloadWeaponClip(string weaponName);

            }


            Console.Clear();
            hud();



            */





        }
        //methods below here

            static void shoot(string weaponName)
        {
            int shoot = Array.IndexOf(weaponTypes, weaponName);

            enemyHealth -= weaponDamage[0];
            ammoCount[0] -= fireRate[0];
            enemyHealth -= weaponDamage[1];
            ammoCount[1] -= fireRate[1];
            enemyHealth -= weaponDamage[2];
            ammoCount[2] -= fireRate[2];
            enemyHealth -= weaponDamage[3];
            ammoCount[3] -= fireRate[3];

            Console.ReadKey();
        }


            static void reloadWeaponClip (string weaponName)
        {
            int reloadWeaponClip = Array.IndexOf(weaponTypes, weaponName);

            if (ammoCount[0] < 14)
            {
                Console.WriteLine(" press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 14 - ammoCount[reloadWeaponClip];
            }
            else if (ammoCount[0] == 0)
            {
                Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 14;
            }

            if (ammoCount[1] < 6)
            {
                Console.WriteLine(" press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 6 - ammoCount[reloadWeaponClip];
            }
            else if (ammoCount[1] == 0)
            {
                Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 6;
            }

            if (ammoCount[2] < 50)
            {
                Console.WriteLine(" press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 50 - ammoCount[reloadWeaponClip];
            }
            else if (ammoCount[2] == 0)
            {
                Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 50;
            }


            if (ammoCount[3] < 4)
            {
                Console.WriteLine(" press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 4 - ammoCount[reloadWeaponClip];
            }
            else if (ammoCount[3] == 0)
            {
                Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                Console.ReadKey();
                ammoCount[reloadWeaponClip] += 4;
            }


                         

            Console.ReadKey();
        }
        // method 2

        static void hud()
        {

            Console.Write(weaponTypes[0]);
            Console.WriteLine("{0,7}",ammoCount[0] + "\n");
            Console.Write(weaponTypes[1]);
            Console.WriteLine("{0,11}",ammoCount[1] + "\n");
            Console.Write(weaponTypes[2]);
            Console.WriteLine("{0,12}",ammoCount[2] + "\n");
            Console.Write(weaponTypes[3]);
            Console.WriteLine("{0,8}",ammoCount[3] + "\n");
        }

        //method 3


        static void weaponSelector()
        {
            Console.WriteLine(" Please choose a weapon: 1 = automatic pistol, 2 = sniper rifle, 3 = machine gun, 4 = rocket launcher" + "\n");

            string weaponSelect = Console.ReadLine(); //store  weapon  selection

            if (weaponSelect == "1")
            {
                Console.WriteLine("You choose to attack your enemy with your trusty Automatic Pistol. " + "\n");
                shoot("automatic pistol");
                reloadWeaponClip("automatic pistol");
                Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
            }

            else if (weaponSelect == "2")
            {
                Console.WriteLine("You choose to attack your enemy with a sleek andd stylish Sniper Rifle. Woot Headshot! " + "\n");
                shoot("sniper rifle");
                reloadWeaponClip("sniper rifle");
                Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
            }
            else if (weaponSelect == "3")
            {
                Console.WriteLine("You choose to attack your enemy with ratt a tatt tattt Machine Gun " + "\n");
                shoot("machine gun");
                reloadWeaponClip("machine gun");
                Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
            }
            else if (weaponSelect == "4")
            {
                Console.WriteLine("You choose to attack your enemy with a FRIKKIN Rocket Launcher... Overkill much? " + "\n");
                shoot("rocket launcher");
                reloadWeaponClip("rocket launcher");
                Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");

            }
            else
            {
                Console.WriteLine("You did not have room to take that weapon with you it is at home in your footlocker." + "\n");

            }
        }








        //methods above here 
    }






}
