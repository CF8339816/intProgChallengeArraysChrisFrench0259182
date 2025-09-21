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
        static int[] ammoLoad = new int[4];
        static int[] weaponDamage = { 15, 50, 35, 100 };
        static int[] fireRate = { 2, 1, 5, 1 };
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
            Console.ReadKey();

            ammoCount[0] = 0;  //sets inital ammo value pistol carried
            ammoCount[1] = 0;   //sets inital ammo value sniper rifle carried
            ammoCount[2] = 0;  //sets inital ammo machine gun  carried
            ammoCount[3] = 0;   //sets inital ammo rocket launcher  carried 

            ammoLoad[0] = 14;  //sets inital ammo value pistol
            ammoLoad[1] = 6;   //sets inital ammo value sniper rifle
            ammoLoad[2] = 50;  //sets inital ammo machine gun
            ammoLoad[3] = 1;   //sets inital ammo rocket launcher

            // Console.ReadKey();


            Console.Clear();
            hud();

            Console.WriteLine("ammo check... ");
            Console.ReadKey();


            Console.Clear();
            hud();

            Console.WriteLine($"You have encountered an enemy. Enemy health is {enemyHealth}. ");
            Console.ReadKey();
            weaponSelector();
            EnemyKill();
            newChallenger();
            newChallenger();
            newChallenger();

            Console.WriteLine($"It has been along day you return to base. ");


        }
        //methods below here

        static void shoot(string weaponName)
        {
            int shoot = Array.IndexOf(weaponTypes, weaponName);

            enemyHealth = enemyHealth - weaponDamage[0];
            enemyHealth = enemyHealth - weaponDamage[1];
            enemyHealth = enemyHealth - weaponDamage[2];
            enemyHealth = enemyHealth - weaponDamage[3];

        }
        static void ammo(string weaponName)
        {
            int ammo = Array.IndexOf(weaponTypes, weaponName);

            ammoCount[0] = ammoCount[0] - fireRate[0];
            ammoCount[1] = ammoCount[1] - fireRate[1];
            ammoCount[2] = ammoCount[2] - fireRate[2];
            ammoCount[3] = ammoCount[3] - fireRate[3];

        }

        static void clip(string weaponName)   //do damaage  to enemy
        {
            int clip = Array.IndexOf(weaponTypes, weaponName);

            ammoLoad[0] = ammoLoad[0] - fireRate[0];
            ammoLoad[1] = ammoLoad[1] - fireRate[1];
            ammoLoad[2] = ammoLoad[2] - fireRate[2];
            ammoLoad[3] = ammoLoad[3] - fireRate[3];

        }

        static void newChallenger()
        {
            enemyHealth = 100;
            Console.WriteLine($"You have encountered another enemy. Enemy health is {enemyHealth}. ");
            Console.ReadKey();
            weaponSelector();
            EnemyKill();
        }

        static void EnemyKill()
        {
            bool isEnemyDead = false; // check to see if enemy is dead

            while (!isEnemyDead)   // while enemy is  not dead this will continue player attack in loop
            {
                if (enemyHealth > 0)
                {
                    Console.WriteLine($"Your enemy yet lives, your task is not yet complete. " + "\n " + "\n ");
                    weaponSelector();
                }
                else
                {
                    Console.WriteLine("you have slain your enemy. You can rest easy until your next inevitable combat." + "\n");
                    Console.WriteLine("looting the enemy's ammo pouches provides some additinal ammo ");
                    ammoCount[0] = ammoCount[0] + 5;  //sets inital ammo value pistol
                    ammoCount[1] = ammoCount[1] + 2;   //sets inital ammo value sniper rifle
                    ammoCount[2] = ammoCount[2] + 13;  //sets inital ammo machine gun
                    ammoCount[3] = ammoCount[3] + 1;
                    Console.ReadKey();
                    Console.Clear();
                    hud();
                    break; // breaks the  loop

                }


            }
        }

            static void reloadWeaponClip(string weaponName)
            {
                int reloadWeaponClip = Array.IndexOf(weaponTypes, weaponName);

                if (ammoLoad[0] == 0)
                {
                    Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                    Console.ReadKey();
                    ammoCount[reloadWeaponClip] += 14;
                    weaponSelector();
                }

                else if (ammoLoad[1] == 0)
                {
                    Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                    Console.ReadKey();
                    ammoCount[reloadWeaponClip] += 6;
                    weaponSelector();
                }

                else if (ammoLoad[2] == 0)
                {
                    Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                    Console.ReadKey();
                    ammoCount[reloadWeaponClip] += 50;
                    weaponSelector();
                }


                else if (ammoLoad[3] == 0)
                {
                    Console.WriteLine("You are empty and cannot fire more press any key to reload. ");
                    Console.ReadKey();
                    ammoCount[reloadWeaponClip] += 4;
                    weaponSelector();

                }

                Console.ReadKey();

            }



            // method 2

            static void hud()
            {
                Console.Write("weapon");
                Console.Write("{0,23}", "ammo carried");
                Console.WriteLine("{0,16}", "ammo loaded" + "\n");
                Console.Write(weaponTypes[0]);
                Console.Write("{0,7}", ammoCount[0]);
                Console.WriteLine("{0,15}", ammoLoad[0]);
                Console.Write(weaponTypes[1]);
                Console.Write("{0,11}", ammoCount[1]);
                Console.WriteLine("{0,15}", ammoLoad[1]);
                Console.Write(weaponTypes[2]);
                Console.Write("{0,12}", ammoCount[2]);
                Console.WriteLine("{0,15}", ammoLoad[2]);
                Console.Write(weaponTypes[3]);
                Console.Write("{0,8}", ammoCount[3]);
                Console.WriteLine("{0,16}", ammoLoad[3] + "\n");
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
                    ammo("automatic pistol");
                    clip("automatic pistol");
                    Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
                    Console.WriteLine($" you have {ammoLoad[0]} Ammo left. ");
                    reloadWeaponClip("automatic pistol");
                    //  Console.ReadKey();
                }

                else if (weaponSelect == "2")
                {
                    Console.WriteLine("You choose to attack your enemy with a sleek andd stylish Sniper Rifle. Woot Headshot! " + "\n");
                    shoot("sniper rifle");
                    ammo("sniper rifle");
                    clip("sniper rifle");
                    Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
                    Console.WriteLine($" you have {ammoLoad[1]} Ammo left. ");
                    reloadWeaponClip("sniper rifle");
                    // Console.ReadKey();
                }
                else if (weaponSelect == "3")
                {
                    Console.WriteLine("You choose to attack your enemy with ratt a tatt tattt Machine Gun " + "\n");
                    shoot("machine gun");
                    ammo("machine gun");
                    clip("machine gun");
                    Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
                    Console.WriteLine($" you have {ammoLoad[2]} Ammo left. ");
                    reloadWeaponClip("machine gun");
                    // Console.ReadKey();
                }
                else if (weaponSelect == "4")
                {
                    Console.WriteLine("You choose to attack your enemy with a FRIKKIN Rocket Launcher... Overkill much? " + "\n");
                    shoot("rocket launcher");
                    ammo("rocket launcher");
                    clip("rocket launcher");
                    Console.WriteLine($" Enemy has taken damage their health is now {enemyHealth}. ");
                    Console.WriteLine($" you have {ammoLoad[3]} Ammo left. ");
                    reloadWeaponClip("rocket launcher");
                    //  Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("You did not have room to take that weapon with you it is at home in your footlocker." + "\n");
                    Console.Clear();
                    hud();
                }
            }


            //methods above here 
        }
    }









