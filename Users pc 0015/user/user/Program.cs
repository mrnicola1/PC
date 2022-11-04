using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace user
{
    internal class Program
    {
        static string CurrentUser;
        static string command;
        static string useramount10;
        static int t;
        static int adminonoff1;
        static int x;
        static void init()
        {
            // hen fra fil
            useramount10 = File.ReadAllText("UserAmount.txt");


        }
        static void Main(string[] args)
        {

         init();
        // Users 
        prøvigen:
            Console.Clear();
            String AdminUser = "Admin User";
            int number1 = 0;
            int UserAmount = 4;
            string adminpassword = "1234";
            //string CurrentUser;
            int adminonoff = 0;
            string shotdown = "Shotdown";
            string logout = "Logout";
            string help = "Help";
            int y;
            
            //string useramount10;

            // Eline computer line
         
            
            while (true)
            {
                //Directory.CreateDirectory(@"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug");
                Console.Write("Welcome to your pc");
                Console.WriteLine(". Please choose a user.");
                Console.WriteLine("\n");
                Console.WriteLine("~~~~~~~~~~~~");

                String readtext1 = File.ReadAllText("Users.txt");
                Console.WriteLine(readtext1);


                
                   
                int.TryParse(Console.ReadLine(), out number1);

                int x = number1 - 1;

                if (x == 0)
                {

                    string UserAmount2 = File.ReadAllText("UserAmount.txt");

                    Console.WriteLine("Name?");
                    string newusername = Console.ReadLine();

                    t = int.Parse(useramount10);
                    useramount10 = (++t).ToString();

                    string dot = ".";
                    File.WriteAllText("UserAmount.txt",useramount10);
                    string newusername2 = ("\n" +useramount10+ newusername);
                    File.AppendAllText("users.txt", newusername2);


                    //string folderName = @"c:\UserFolders";
                    //File.Delete("UserAmount.txt");


                    //  File.Create("\\katalog1\\"+CurrentUser);

                    //string sti = @"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug"+"\\newusername2\\";
                    //Directory.CreateDirectory(@"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug");

                    Console.WriteLine("New user called " + newusername + " was made");
                    Console.ReadLine();
                    goto prøvigen;



                }
            



                if (x == 1)
                {
                    Console.WriteLine("Admin account needs password");
                    Console.Write("password -->");
                    string adminpassword2 = Console.ReadLine();
                    if (adminpassword2 == adminpassword)
                    {
                        Console.WriteLine("Password correct");
                        CurrentUser = File.ReadLines("Users.txt").Skip(x).Take(1).First();
                        Console.WriteLine("Your now logged in as " + CurrentUser);
                        
                        adminonoff = 1;
                        adminonoff1 = 1;
                        goto loggetind;
                    }
                    else
                    {
                        Console.WriteLine("Password error");
                        Console.ReadLine();
                        goto prøvigen;
                    }
                }


              // if (x > t)
               //{
                   // Console.Clear();
                   // goto prøvigen;
               //}
               
               


                if (x > 0)
                {
                    CurrentUser = File.ReadLines("Users.txt").Skip(x).Take(1).First();
                    Console.WriteLine(CurrentUser);
                    //Console.WriteLine("Stop"); ( test ) 
                    Console.WriteLine("Your now logged in as " + CurrentUser);

                    
                    goto loggetind;
                }
                //Console.WriteLine("Please select a real user");
                Console.Clear();


            }





        loggetind:
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
           
            


            //  string path = "C:/Users/nico6/OneDrive/C#/Users pc 0015/user/user/bin/Debug/Programs/Command Prompt.lnk";
            // "C:\Users\nico6\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\Windows PowerShell.lnk"




            Console.WriteLine("Welcome to your computer " + CurrentUser);
            Console.WriteLine("type Help to see what you can do with the computer");
            Console.WriteLine("Type Logout to logout of your current user");
            Console.WriteLine("Type Shotdown to shotdown your pc");
            //Console.ReadLine();

            while (true)
            {
                command = Console.ReadLine();

                if (command == shotdown)
                {
                    Environment.Exit(0);
                }

                if (command == logout)
                {
                    goto prøvigen;
                }

                if (command == help)
                {
                    Console.Clear();
                    //Console.ReadLine();


                    while (true)
                    {

                        

                       
                        {
                            Console.Clear();

                            Console.WriteLine("1. PowerShell <-- (Requires Admin perms)");
                            Console.WriteLine("2. Control panel <-- (Requires Admin perms)");
                            Console.WriteLine("3. Shotdown");
                            Console.WriteLine("4. Logout");
                            Console.WriteLine("5. Google");
                            Console.WriteLine("6. Mail//");
                            Console.WriteLine("7. Task Manager");
                            Console.WriteLine("8. Lærepladsen");
                            Console.WriteLine("9. GitHub");
                           // Console.WriteLine("10. Folder System");
                            
                           

                            _ = int.TryParse(Console.ReadLine(), out y); 

                          


                            if (y == 1)
                            {



                                if (adminonoff == 1)
                                {
                                    Process.Start(@"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug\Programs\Windows PowerShell\Windows PowerShell.lnk");
                                }
                                else
                                {
                                    Console.WriteLine("Powershell requires admin permissions");
                                    Console.ReadLine();
                                }

                            }

                            if (y == 5)
                            {
                                System.Diagnostics.Process.Start("http://google.com");
                            }


                            if (y == 6)
                            {

                            }

                            if (y == 7)
                            {
                                Process.Start(@"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug\Programs\Task Manager\Task Manager.lnk");
                            }

                            if (y == 3)
                            {
                                Environment.Exit(0);
                            }

                            if (y == 4)
                            {
                                goto prøvigen;
                            }

                            if (y == 8)
                            {
                                System.Diagnostics.Process.Start("https://www.laerepladsen.dk/");
                            }
                            
                            if (y == 9)
                            {
                                System.Diagnostics.Process.Start("https://github.com/");
                            }

                            if (y == 2)
                            {
                                if (adminonoff== 1)
                                {
                                    Process.Start(@"C:\Users\nico6\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\System Tools\Control Panel.lnk");
                                }
                                else
                                {
                                    Console.WriteLine("Powershell requires admin permissions");
                                    Console.ReadLine();
                                }


                            }

                            

                        }




                    }

                    //File.Create(@"C:\Users\nico6\OneDrive\C#\Users pc 0015\user\user\bin\Debug");

                }



                Console.WriteLine("I dont understand the command. Try again, and remember to start with an uppercase.");




            }
        }
    }
}
