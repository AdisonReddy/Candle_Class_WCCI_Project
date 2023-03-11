using System;
using System.Timers;

namespace classOfMyChoice
{
    public class Candle
    {
        private string name;        
        private string color;
        private string scent;           //fields of the class,,, which need the properties to assign the values for these fields
        private string size;
        private bool lit = false;
        
        public string Name { get; set; }
        public string Color { get; set; }
        public string Scent { get; set; }     //Properties of the Candle class,,,, how you get/set the fields
        public string Size { get; set; }
        public bool Lit { get; set; }
        
        public Candle(string name, string color, string scent, string size, bool lit, string onShelf)
        {
            Name = name;
            Color = color;
            Scent = scent;                          //Constructor of new candles in Candle class
            Size = size;
            Lit = lit;
            
        }




        public void NameYourCandle()
        {
            Console.Clear();
            Console.WriteLine("Type in the name of your candle, Hit Enter when complete\n");
            name = Console.ReadLine();
        }




        public void CandleColor()
        {
            Console.Clear();
            Console.WriteLine("Type in the color of your candle, Hit Enter when complete\n");
            color = Console.ReadLine();
        }




        public void CandleScent()
        {
            Console.Clear();
            Console.WriteLine("Type in the scent of your candle, Hit Enter when complete\n");
            scent = Console.ReadLine();
        }




        public void CandleSize()
        {
            Console.Clear();
            Console.WriteLine("Type in the size of your candle. Small, Medium, or Large. Hit Enter when complete\n");
            size = Console.ReadLine().ToLower();
        }




        public void PutItOnTheShelf()
        {
            Console.Clear();
            Console.WriteLine("Your " + color + ", " + name +" candle looks great!\n");
            Console.WriteLine("Now that it's on the shelf lets go back to the main menu to light it.\nHit Enter");
            Console.ReadLine();
        }




        public void LightMe()
        {
            //Below is multiple timers nested. the only things that change with each nesting iteration
            //are the variables for each of the timers (flameMovement[S-S13])   and   the Asteriks change position slightly (to animate the flame and candle)

            //the try/catch that is wrapped around it Targets the specific NullReferenceException in case the user does not enter a candle size before trying to light it.

            //the .Stop and .Dispose in combanation ensure that the already used timers dont clog up processing.

            try
            {

                if (size.Contains("small"))
                {



                    Console.Clear();
                    lit = true;
                    Console.WriteLine("\n");
                    Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                    Console.WriteLine(" *******\n *******\n *******\n *******\n *******\n\n");
                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");

                    System.Timers.Timer flameMovementS = new(0500);//instatiates new timer 
                    flameMovementS.Start();
                    flameMovementS.Elapsed += FlameMovementS_Elapsed; // says once timer is elapsed go to _Elapsed function
                    Console.ReadLine();     //keeping console running
                    void FlameMovementS_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                    {
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                        Console.WriteLine(" *******\n *******\n *******\n *******\n *******\n\n");
                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                        flameMovementS.Stop();
                        flameMovementS.Dispose();
                            System.Timers.Timer flameMovementS1 = new(0500);//instatiates new timer called flameDuration
                            flameMovementS1.Start();
                            flameMovementS1.Elapsed += FlameMovementS1_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                            Console.ReadLine();     //keeping console running
                        void FlameMovementS1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                            Console.WriteLine(" *******\n *******\n *******\n *******\n *******\n\n");
                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                            flameMovementS1.Stop();
                            flameMovementS1.Dispose();
                                System.Timers.Timer flameMovementS2 = new(0500);//instatiates new timer called flameDuration
                                flameMovementS2.Start();
                                flameMovementS2.Elapsed += FlameMovementS2_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                Console.ReadLine();     //keeping console running
                            void FlameMovementS2_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n");
                                Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                Console.WriteLine(" *******\n *******\n *******\n *******\n *******\n\n");
                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                flameMovementS2.Stop();
                                flameMovementS2.Stop();
                                    System.Timers.Timer flameMovementS3 = new(0500);//instatiates new timer called flameDuration
                                    flameMovementS3.Start();
                                    flameMovementS3.Elapsed += FlameMovementS3_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                    Console.ReadLine();     //keeping console running
                                void FlameMovementS3_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n");
                                    Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                    Console.WriteLine(" *******\n *******\n *******\n *******\n\n");
                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                    flameMovementS3.Stop();
                                    flameMovementS3.Dispose();
                                        System.Timers.Timer flameMovementS4 = new(0500);//instatiates new timer called flameDuration
                                        flameMovementS4.Start();
                                        flameMovementS4.Elapsed += FlameMovementS4_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                        Console.ReadLine();     //keeping console running
                                    void FlameMovementS4_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n");
                                        Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                        Console.WriteLine(" *******\n *******\n *******\n *******\n\n");
                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                        flameMovementS4.Stop();
                                        flameMovementS4.Dispose();
                                            System.Timers.Timer flameMovementS5 = new(0500);//instatiates new timer called flameDuration
                                            flameMovementS5.Start();
                                            flameMovementS5.Elapsed += FlameMovementS5_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                            Console.ReadLine();     //keeping console running
                                        void FlameMovementS5_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n");
                                            Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                            Console.WriteLine(" *******\n *******\n *******\n *******\n\n");
                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                            flameMovementS5.Stop();
                                            flameMovementS5.Dispose();
                                                System.Timers.Timer flameMovementS6 = new(0500);//instatiates new timer called flameDuration
                                                flameMovementS6.Start();
                                                flameMovementS6.Elapsed += FlameMovementS6_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                Console.ReadLine();     //keeping console running
                                            void FlameMovementS6_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n\n\n");
                                                Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                                Console.WriteLine(" *******\n *******\n *******\n\n");
                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                flameMovementS6.Stop();
                                                flameMovementS6.Dispose();
                                                    System.Timers.Timer flameMovementS7 = new(0500);//instatiates new timer called flameDuration
                                                    flameMovementS7.Start();
                                                    flameMovementS7.Elapsed += FlameMovementS7_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                    Console.ReadLine();     //keeping console running
                                                void FlameMovementS7_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n");
                                                    Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                                    Console.WriteLine(" *******\n *******\n *******\n\n");
                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                    flameMovementS7.Stop();
                                                    flameMovementS7.Dispose();
                                                        System.Timers.Timer flameMovementS8 = new(0500);//instatiates new timer called flameDuration
                                                        flameMovementS8.Start();
                                                        flameMovementS8.Elapsed += FlameMovementS8_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                        Console.ReadLine();     //keeping console running
                                                    void FlameMovementS8_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("\n\n\n");
                                                        Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                                        Console.WriteLine(" *******\n *******\n *******\n\n");
                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                        flameMovementS8.Stop();
                                                        flameMovementS8.Dispose();
                                                            System.Timers.Timer flameMovementS9 = new(0500);//instatiates new timer called flameDuration
                                                            flameMovementS9.Start();
                                                            flameMovementS9.Elapsed += FlameMovementS9_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                            Console.ReadLine();     //keeping console running
                                                        void FlameMovementS9_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n");
                                                            Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                                            Console.WriteLine(" *******\n *******\n *******\n\n");
                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                            flameMovementS9.Stop();
                                                            flameMovementS9.Dispose();
                                                                System.Timers.Timer flameMovementS10 = new(0500);//instatiates new timer called flameDuration
                                                                flameMovementS10.Start();
                                                                flameMovementS10.Elapsed += FlameMovementS10_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                Console.ReadLine();     //keeping console running
                                                            void FlameMovementS10_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n\n\n\n");
                                                                Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                                                Console.WriteLine(" *******\n *******\n\n");
                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                flameMovementS10.Stop();
                                                                flameMovementS10.Dispose();
                                                                    System.Timers.Timer flameMovementS11 = new(0500);//instatiates new timer called flameDuration
                                                                    flameMovementS11.Start();
                                                                    flameMovementS11.Elapsed += FlameMovementS11_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                    Console.ReadLine();     //keeping console running
                                                                void FlameMovementS11_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Console.WriteLine("    *    \n   ***    \n   ****  \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                                                    Console.WriteLine(" *******\n *******\n\n");
                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                    flameMovementS11.Stop();
                                                                    flameMovementS11.Dispose();
                                                                        System.Timers.Timer flameMovementS12 = new(0500);//instatiates new timer called flameDuration
                                                                        flameMovementS12.Start();
                                                                        flameMovementS12.Elapsed += FlameMovementS12_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                        Console.ReadLine();     //keeping console running
                                                                    void FlameMovementS12_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n\n\n\n");
                                                                        Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position b
                                                                        Console.WriteLine(" *******\n *******\n\n");
                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                        flameMovementS12.Stop();
                                                                        flameMovementS12.Dispose();
                                                                            System.Timers.Timer flameMovementS13 = new(0500);//instatiates new timer called flameDuration
                                                                            flameMovementS13.Start();
                                                                            flameMovementS13.Elapsed += FlameMovementS13_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                            Console.ReadLine();     //keeping console running
                                                                        void FlameMovementS13_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("\n\n\n\n");
                                                                            Console.WriteLine("    *    \n  ***     \n  ****   \n  *****  \n   ***  \n    *    \n    *    "); //flame position a
                                                                            Console.WriteLine(" *******\n *******\n\n");
                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                            flameMovementS13.Stop();
                                                                            flameMovementS13.Dispose();
                                                                                System.Timers.Timer flameDuration = new(0500);//instatiates new timer called flameDuration
                                                                                flameDuration.Start();
                                                                                flameDuration.Elapsed += FlameDuration_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                Console.ReadLine();     //keeping console running
                                                                            void FlameDuration_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                            {
                                                                                Console.Clear();
                                                                                lit = false;
                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                Console.WriteLine("    *    \n    *    ");
                                                                                Console.WriteLine(" *******\n *******\n\n");
                                                                                Console.WriteLine("Your candle went out.\n");
                                                                                Console.WriteLine("Hit Enter, If you would like to make another candle at the main menu.");
                                                                                flameDuration.Stop();
                                                                            }
                                                                            flameDuration.Stop();
                                                                            flameDuration.Dispose();



                                                                        }



                                                                    }



                                                                }



                                                            }
                                                        }


                                                    }

                                                }



                                            }



                                        }



                                    }



                                }
                            }


                        }

                    }


                }



                if (size.Contains("medium"))
                {



                    Console.Clear();
                    lit = true;
                    Console.WriteLine("\n");
                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                    Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");

                    System.Timers.Timer flameMovementM = new(0500);//instatiates new timer called flameDuration
                    flameMovementM.Start();
                    flameMovementM.Elapsed += FlameMovementM_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                    Console.ReadLine();     //keeping console running
                    void FlameMovementM_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                    {
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                        Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                        flameMovementM.Stop();
                        flameMovementM.Dispose();
                            System.Timers.Timer flameMovementM1 = new(0500);//instatiates new timer called flameDuration
                            flameMovementM1.Start();
                            flameMovementM1.Elapsed += FlameMovementM1_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                            Console.ReadLine();     //keeping console running
                        void FlameMovementM1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n");
                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                            Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                            flameMovementM1.Stop();
                            flameMovementM1.Dispose();
                                System.Timers.Timer flameMovementM2 = new(0500);//instatiates new timer called flameDuration
                                flameMovementM2.Start();
                                flameMovementM2.Elapsed += FlameMovementM2_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                Console.ReadLine();     //keeping console running
                            void FlameMovementM2_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                flameMovementM2.Stop();
                                flameMovementM2.Stop();
                                    System.Timers.Timer flameMovementM3 = new(0500);//instatiates new timer called flameDuration
                                    flameMovementM3.Start();
                                    flameMovementM3.Elapsed += FlameMovementM3_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                    Console.ReadLine();     //keeping console running
                                void FlameMovementM3_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n");
                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                    Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                    flameMovementM3.Stop();
                                    flameMovementM3.Dispose();
                                        System.Timers.Timer flameMovementM4 = new(0500);//instatiates new timer called flameDuration
                                        flameMovementM4.Start();
                                        flameMovementM4.Elapsed += FlameMovementM4_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                        Console.ReadLine();     //keeping console running
                                    void FlameMovementM4_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n");
                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                        Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                        flameMovementM4.Stop();
                                        flameMovementM4.Dispose();
                                            System.Timers.Timer flameMovementM5 = new(0500);//instatiates new timer called flameDuration
                                            flameMovementM5.Start();
                                            flameMovementM5.Elapsed += FlameMovementM5_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                            Console.ReadLine();     //keeping console running
                                            void FlameMovementM5_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n\n");
                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                            Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                            flameMovementM5.Stop();
                                            flameMovementM5.Dispose();
                                                System.Timers.Timer flameMovementM6 = new(0500);//instatiates new timer called flameDuration
                                                flameMovementM6.Start();
                                                flameMovementM6.Elapsed += FlameMovementM6_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                Console.ReadLine();     //keeping console running
                                            void FlameMovementM6_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n\n\n\n\n");
                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                flameMovementM6.Stop();
                                                flameMovementM6.Dispose();
                                                    System.Timers.Timer flameMovementM7 = new(0500);//instatiates new timer called flameDuration
                                                    flameMovementM7.Start();
                                                    flameMovementM7.Elapsed += FlameMovementM7_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                    Console.ReadLine();     //keeping console running
                                                void FlameMovementM7_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n\n\n\n");
                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                    Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                    flameMovementM7.Stop();
                                                    flameMovementM7.Dispose();
                                                        System.Timers.Timer flameMovementM8 = new(0500);//instatiates new timer called flameDuration
                                                        flameMovementM8.Start();
                                                        flameMovementM8.Elapsed += FlameMovementM8_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                        Console.ReadLine();     //keeping console running
                                                    void FlameMovementM8_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("\n\n\n\n\n\n");
                                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                        Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                        flameMovementM8.Stop();
                                                        flameMovementM8.Dispose();
                                                            System.Timers.Timer flameMovementM9 = new(0500);//instatiates new timer called flameDuration
                                                            flameMovementM9.Start();
                                                            flameMovementM9.Elapsed += FlameMovementM9_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                            Console.ReadLine();     //keeping console running
                                                        void FlameMovementM9_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n");
                                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a 
                                                            Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n *************\n\n");
                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                            flameMovementM9.Stop();
                                                            flameMovementM9.Dispose();
                                                                System.Timers.Timer flameMovementM10 = new(0500);//instatiates new timer called flameDuration
                                                                flameMovementM10.Start();
                                                                flameMovementM10.Elapsed += FlameMovementM10_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                Console.ReadLine();     //keeping console running
                                                            void FlameMovementM10_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n\n\n\n\n\n\n");
                                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n\n");
                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                flameMovementM10.Stop();
                                                                flameMovementM10.Dispose();
                                                                    System.Timers.Timer flameMovementM11 = new(0500);//instatiates new timer called flameDuration
                                                                    flameMovementM11.Start();
                                                                    flameMovementM11.Elapsed += FlameMovementM11_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                    Console.ReadLine();     //keeping console running
                                                                void FlameMovementM11_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n\n\n\n");
                                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                    Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n\n");
                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                    flameMovementM11.Stop();
                                                                    flameMovementM11.Dispose();
                                                                        System.Timers.Timer flameMovementM12 = new(0500);//instatiates new timer called flameDuration
                                                                        flameMovementM12.Start();
                                                                        flameMovementM12.Elapsed += FlameMovementM12_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                        Console.ReadLine();     //keeping console running
                                                                    void FlameMovementM12_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n\n\n\n\n\n\n");
                                                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                        Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n\n");
                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                        flameMovementM12.Stop();
                                                                        flameMovementM12.Dispose();
                                                                            System.Timers.Timer flameMovementM13 = new(0500);//instatiates new timer called flameDuration
                                                                            flameMovementM13.Start();
                                                                            flameMovementM13.Elapsed += FlameMovementM13_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                            Console.ReadLine();     //keeping console running
                                                                        void FlameMovementM13_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("\n\n\n\n\n\n\n");
                                                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                            Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n\n");
                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                            flameMovementM13.Stop();
                                                                            flameMovementM13.Dispose();
                                                                                System.Timers.Timer flameMovementM14 = new(0500);//instatiates new timer called flameDuration
                                                                                flameMovementM14.Start();
                                                                                flameMovementM14.Elapsed += FlameMovementM14_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                Console.ReadLine();     //keeping console running
                                                                            void FlameMovementM14_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("\n\n\n\n\n\n\n");
                                                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                Console.WriteLine(" *************\n *************\n *************\n *************\n *************\n\n");
                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                flameMovementM14.Stop();
                                                                                flameMovementM14.Dispose();
                                                                                    System.Timers.Timer flameMovementM15 = new(0500);//instatiates new timer called flameDuration
                                                                                    flameMovementM15.Start();
                                                                                    flameMovementM15.Elapsed += FlameMovementM15_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                    Console.ReadLine();     //keeping console running
                                                                                void FlameMovementM15_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                {
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                    Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                    flameMovementM15.Stop();
                                                                                    flameMovementM15.Dispose();
                                                                                        System.Timers.Timer flameMovementM16 = new(0500);//instatiates new timer called flameDuration
                                                                                        flameMovementM16.Start();
                                                                                        flameMovementM16.Elapsed += FlameMovementM16_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                        Console.ReadLine();     //keeping console running
                                                                                    void FlameMovementM16_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                        Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                        flameMovementM16.Stop();
                                                                                        flameMovementM16.Stop();
                                                                                            System.Timers.Timer flameMovementM17 = new(0500);//instatiates new timer called flameDuration
                                                                                            flameMovementM17.Start();
                                                                                            flameMovementM17.Elapsed += FlameMovementM17_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                            Console.ReadLine();     //keeping console running
                                                                                        void FlameMovementM17_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                            Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                            flameMovementM17.Stop();
                                                                                            flameMovementM17.Dispose();
                                                                                                System.Timers.Timer flameMovementM18 = new(0500);//instatiates new timer called flameDuration
                                                                                                flameMovementM18.Start();
                                                                                                flameMovementM18.Elapsed += FlameMovementM18_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                Console.ReadLine();     //keeping console running
                                                                                            void FlameMovementM18_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                                Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                flameMovementM18.Stop();
                                                                                                flameMovementM18.Dispose();
                                                                                                    System.Timers.Timer flameMovementM19 = new(0500);//instatiates new timer called flameDuration
                                                                                                    flameMovementM19.Start();
                                                                                                    flameMovementM19.Elapsed += FlameMovementM19_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                void FlameMovementM19_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                {
                                                                                                    Console.Clear();
                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                                    Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                    flameMovementM19.Stop();
                                                                                                    flameMovementM19.Dispose();
                                                                                                        System.Timers.Timer flameMovementM20 = new(0500);//instatiates new timer called flameDuration
                                                                                                        flameMovementM20.Start();
                                                                                                        flameMovementM20.Elapsed += FlameMovementM20_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                    void FlameMovementM20_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                                        Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                        flameMovementM20.Stop();
                                                                                                        flameMovementM20.Dispose();
                                                                                                            System.Timers.Timer flameMovementM21 = new(0500);//instatiates new timer called flameDuration
                                                                                                            flameMovementM21.Start();
                                                                                                            flameMovementM21.Elapsed += FlameMovementM21_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                        void FlameMovementM21_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                        {
                                                                                                            Console.Clear();
                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                                            Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                            flameMovementM21.Stop();
                                                                                                            flameMovementM21.Dispose();
                                                                                                                System.Timers.Timer flameMovementM22 = new(0500);//instatiates new timer called flameDuration
                                                                                                                flameMovementM22.Start();
                                                                                                                flameMovementM22.Elapsed += FlameMovementM22_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                            void FlameMovementM22_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                                                Console.WriteLine(" *************\n *************\n *************\n *************\n\n");
                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                flameMovementM22.Stop();
                                                                                                                flameMovementM22.Dispose();
                                                                                                                    System.Timers.Timer flameMovementM23 = new(0500);//instatiates new timer called flameDuration
                                                                                                                    flameMovementM23.Start();
                                                                                                                    flameMovementM23.Elapsed += FlameMovementM23_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                                void FlameMovementM23_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                {
                                                                                                                    Console.Clear();
                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                                                    Console.WriteLine(" *************\n *************\n *************\n\n");
                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                    flameMovementM23.Stop();
                                                                                                                    flameMovementM23.Dispose();
                                                                                                                        System.Timers.Timer flameMovementM24 = new(0500);//instatiates new timer called flameDuration
                                                                                                                        flameMovementM24.Start();
                                                                                                                        flameMovementM24.Elapsed += FlameMovementM24_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                    void FlameMovementM24_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                    {
                                                                                                                        Console.Clear();
                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                        Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                                                        Console.WriteLine(" *************\n *************\n *************\n\n");
                                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                        flameMovementM24.Stop();
                                                                                                                        flameMovementM24.Dispose();
                                                                                                                            System.Timers.Timer flameMovementM25 = new(0500);//instatiates new timer called flameDuration
                                                                                                                            flameMovementM25.Start();
                                                                                                                            flameMovementM25.Elapsed += FlameMovementM25_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                                        void FlameMovementM25_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                        {
                                                                                                                            Console.Clear();
                                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                            Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                                                            Console.WriteLine(" *************\n *************\n *************\n\n");
                                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                            flameMovementM25.Stop();
                                                                                                                            flameMovementM25.Dispose();
                                                                                                                                System.Timers.Timer flameMovementM26 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                flameMovementM26.Start();
                                                                                                                                flameMovementM26.Elapsed += FlameMovementM26_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                                            void FlameMovementM26_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                            {
                                                                                                                                Console.Clear();
                                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                                Console.WriteLine("       *    \n     ***     \n     ****   \n     *****  \n      ***  \n       *    \n       *    "); //flame position b
                                                                                                                                Console.WriteLine(" *************\n *************\n *************\n\n");
                                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                flameMovementM26.Stop();
                                                                                                                                flameMovementM26.Dispose();
                                                                                                                                    System.Timers.Timer flameMovementM27 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                    flameMovementM27.Start();
                                                                                                                                    flameMovementM27.Elapsed += FlameMovementM27_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                                                void FlameMovementM27_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                {
                                                                                                                                    Console.Clear();
                                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                    Console.WriteLine("       *    \n      ***    \n      ****  \n     *****  \n      ***  \n       *    \n       *    "); //flame position a
                                                                                                                                    Console.WriteLine(" *************\n *************\n\n");
                                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                    flameMovementM27.Stop();
                                                                                                                                    flameMovementM27.Dispose();
                                                                                                                                        System.Timers.Timer flameDurationM = new(0500);//instatiates new timer called flameDuration
                                                                                                                                        flameDurationM.Start();
                                                                                                                                        flameDurationM.Elapsed += FlameDurationM_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                                    void FlameDurationM_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                    {
                                                                                                                                        Console.Clear();
                                                                                                                                        lit = false;
                                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                        Console.WriteLine("       *    \n       *    ");
                                                                                                                                        Console.WriteLine(" *************\n *************\n\n");
                                                                                                                                        Console.WriteLine("Your candle went out.\n");
                                                                                                                                        Console.WriteLine("Hit Enter, If you would like to make another candle at the main menu.");
                                                                                                                                        flameDurationM.Stop();
                                                                                                                                    }
                                                                                                                                    flameDurationM.Stop();
                                                                                                                                    flameDurationM.Dispose();



                                                                                                                                }



                                                                                                                            }



                                                                                                                        }



                                                                                                                    }
                                                                                                                }


                                                                                                            }

                                                                                                        }



                                                                                                    }



                                                                                                }



                                                                                            }



                                                                                        }
                                                                                    }


                                                                                }

                                                                            }




                                                                        }



                                                                    }



                                                                }



                                                            }
                                                        }


                                                    }

                                                }



                                            }



                                        }



                                    }



                                }
                            }


                        }

                    }


                }



                if (size.Contains("large"))
                {
                    Console.Clear();
                    lit = true;
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    ");//flame position A
                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");

                    System.Timers.Timer flameMovementL = new(0500);//instatiates new timer called flameDuration
                    flameMovementL.Start();
                    flameMovementL.Elapsed += FlameMovementL_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                    Console.ReadLine();     //keeping console running
                    void FlameMovementL_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                        flameMovementL.Stop();
                        flameMovementL.Dispose();
                            System.Timers.Timer flameMovementM1 = new(0500);//instatiates new timer called flameDuration
                            flameMovementM1.Start();
                            flameMovementM1.Elapsed += FlameMovementM1_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                            Console.ReadLine();     //keeping console running
                        void FlameMovementM1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\n");
                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                            flameMovementM1.Stop();
                            flameMovementM1.Dispose();
                                System.Timers.Timer flameMovementM2 = new(0500);//instatiates new timer called flameDuration
                                flameMovementM2.Start();
                                flameMovementM2.Elapsed += FlameMovementM2_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                Console.ReadLine();     //keeping console running
                            void FlameMovementM2_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n\n");
                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                flameMovementM2.Stop();
                                flameMovementM2.Stop();
                                    System.Timers.Timer flameMovementM3 = new(0500);//instatiates new timer called flameDuration
                                    flameMovementM3.Start();
                                    flameMovementM3.Elapsed += FlameMovementM3_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                Console.ReadLine();     //keeping console running
                                void FlameMovementM3_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n\n\n");
                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                    flameMovementM3.Stop();
                                    flameMovementM3.Dispose();
                                        System.Timers.Timer flameMovementM4 = new(0500);//instatiates new timer called flameDuration
                                        flameMovementM4.Start();
                                        flameMovementM4.Elapsed += FlameMovementM4_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                        Console.ReadLine();     //keeping console running
                                    void FlameMovementM4_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\n\n\n\n");
                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                        flameMovementM4.Stop();
                                        flameMovementM4.Dispose();
                                            System.Timers.Timer flameMovementM5 = new(0500);//instatiates new timer called flameDuration
                                            flameMovementM5.Start();
                                            flameMovementM5.Elapsed += FlameMovementM5_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                            Console.ReadLine();     //keeping console running
                                        void FlameMovementM5_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\n\n\n\n");
                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                            flameMovementM5.Stop();
                                            flameMovementM5.Dispose();
                                                System.Timers.Timer flameMovementM6 = new(0500);//instatiates new timer called flameDuration
                                                flameMovementM6.Start();
                                                flameMovementM6.Elapsed += FlameMovementM6_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                Console.ReadLine();     //keeping console running
                                            void FlameMovementM6_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n\n\n");
                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                flameMovementM6.Stop();
                                                flameMovementM6.Dispose();
                                                    System.Timers.Timer flameMovementM7 = new(0500);//instatiates new timer called flameDuration
                                                    flameMovementM7.Start();
                                                    flameMovementM7.Elapsed += FlameMovementM7_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                    Console.ReadLine();     //keeping console running
                                                void FlameMovementM7_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\n\n\n");
                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                    flameMovementM7.Stop();
                                                    flameMovementM7.Dispose();
                                                        System.Timers.Timer flameMovementM8 = new(0500);//instatiates new timer called flameDuration
                                                        flameMovementM8.Start();
                                                        flameMovementM8.Elapsed += FlameMovementM8_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                        Console.ReadLine();     //keeping console running
                                                    void FlameMovementM8_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("\n\n\n");
                                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                        flameMovementM8.Stop();
                                                        flameMovementM8.Dispose();
                                                            System.Timers.Timer flameMovementM9 = new(0500);//instatiates new timer called flameDuration
                                                            flameMovementM9.Start();
                                                            flameMovementM9.Elapsed += FlameMovementM9_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                            Console.ReadLine();     //keeping console running
                                                        void FlameMovementM9_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n");
                                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a 
                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                            flameMovementM9.Stop();
                                                            flameMovementM9.Dispose();
                                                                System.Timers.Timer flameMovementM10 = new(0500);//instatiates new timer called flameDuration
                                                                flameMovementM10.Start();
                                                                flameMovementM10.Elapsed += FlameMovementM10_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                Console.ReadLine();     //keeping console running
                                                            void FlameMovementM10_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("\n\n\n\n");
                                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                flameMovementM10.Stop();
                                                                flameMovementM10.Dispose();
                                                                    System.Timers.Timer flameMovementM11 = new(0500);//instatiates new timer called flameDuration
                                                                    flameMovementM11.Start();
                                                                    flameMovementM11.Elapsed += FlameMovementM11_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                    Console.ReadLine();     //keeping console running
                                                                void FlameMovementM11_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("\n\n\n\n");
                                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                    flameMovementM11.Stop();
                                                                    flameMovementM11.Dispose();
                                                                        System.Timers.Timer flameMovementM12 = new(0500);//instatiates new timer called flameDuration
                                                                        flameMovementM12.Start();
                                                                        flameMovementM12.Elapsed += FlameMovementM12_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                        Console.ReadLine();     //keeping console running
                                                                    void FlameMovementM12_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                    {
                                                                        Console.Clear();
                                                                        Console.WriteLine("\n\n\n\n\n");
                                                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                        flameMovementM12.Stop();
                                                                        flameMovementM12.Dispose();
                                                                            System.Timers.Timer flameMovementM13 = new(0500);//instatiates new timer called flameDuration
                                                                            flameMovementM13.Start();
                                                                            flameMovementM13.Elapsed += FlameMovementM13_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                            Console.ReadLine();     //keeping console running
                                                                        void FlameMovementM13_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                        {
                                                                            Console.Clear();
                                                                            Console.WriteLine("\n\n\n\n\n");
                                                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                            flameMovementM13.Stop();
                                                                            flameMovementM13.Dispose();
                                                                                System.Timers.Timer flameMovementM14 = new(0500);//instatiates new timer called flameDuration
                                                                                flameMovementM14.Start();
                                                                                flameMovementM14.Elapsed += FlameMovementM14_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                Console.ReadLine();     //keeping console running
                                                                            void FlameMovementM14_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                            {
                                                                                Console.Clear();
                                                                                Console.WriteLine("\n\n\n\n\n");
                                                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                flameMovementM14.Stop();
                                                                                flameMovementM14.Dispose();
                                                                                    System.Timers.Timer flameMovementM15 = new(0500);//instatiates new timer called flameDuration
                                                                                    flameMovementM15.Start();
                                                                                    flameMovementM15.Elapsed += FlameMovementM15_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                    Console.ReadLine();     //keeping console running
                                                                                void FlameMovementM15_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                {
                                                                                    Console.Clear();
                                                                                    Console.WriteLine("\n\n\n\n\n");
                                                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                    flameMovementM15.Stop();
                                                                                    flameMovementM15.Dispose();
                                                                                        System.Timers.Timer flameMovementM16 = new(0500);//instatiates new timer called flameDuration
                                                                                        flameMovementM16.Start();
                                                                                        flameMovementM16.Elapsed += FlameMovementM16_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                        Console.ReadLine();     //keeping console running
                                                                                    void FlameMovementM16_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                    {
                                                                                        Console.Clear();
                                                                                        Console.WriteLine("\n\n\n\n\n\n");
                                                                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                        flameMovementM16.Stop();
                                                                                        flameMovementM16.Stop();
                                                                                            System.Timers.Timer flameMovementM17 = new(0500);//instatiates new timer called flameDuration
                                                                                            flameMovementM17.Start();
                                                                                            flameMovementM17.Elapsed += FlameMovementM17_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                            Console.ReadLine();     //keeping console running
                                                                                        void FlameMovementM17_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                        {
                                                                                            Console.Clear();
                                                                                            Console.WriteLine("\n\n\n\n\n\n");
                                                                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                            flameMovementM17.Stop();
                                                                                            flameMovementM17.Dispose();
                                                                                                System.Timers.Timer flameMovementM18 = new(0500);//instatiates new timer called flameDuration
                                                                                                flameMovementM18.Start();
                                                                                                flameMovementM18.Elapsed += FlameMovementM18_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                Console.ReadLine();     //keeping console running
                                                                                            void FlameMovementM18_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                            {
                                                                                                Console.Clear();
                                                                                                Console.WriteLine("\n\n\n\n\n\n");
                                                                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                flameMovementM18.Stop();
                                                                                                flameMovementM18.Dispose();
                                                                                                    System.Timers.Timer flameMovementM19 = new(0500);//instatiates new timer called flameDuration
                                                                                                    flameMovementM19.Start();
                                                                                                    flameMovementM19.Elapsed += FlameMovementM19_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                void FlameMovementM19_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                {
                                                                                                    Console.Clear();
                                                                                                    Console.WriteLine("\n\n\n\n\n\n");
                                                                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                    flameMovementM19.Stop();
                                                                                                    flameMovementM19.Dispose();
                                                                                                        System.Timers.Timer flameMovementM20 = new(0500);//instatiates new timer called flameDuration
                                                                                                        flameMovementM20.Start();
                                                                                                        flameMovementM20.Elapsed += FlameMovementM20_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                    void FlameMovementM20_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                    {
                                                                                                        Console.Clear();
                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n");
                                                                                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                        flameMovementM20.Stop();
                                                                                                        flameMovementM20.Dispose();
                                                                                                            System.Timers.Timer flameMovementM21 = new(0500);//instatiates new timer called flameDuration
                                                                                                            flameMovementM21.Start();
                                                                                                            flameMovementM21.Elapsed += FlameMovementM21_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                        void FlameMovementM21_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                        {
                                                                                                            Console.Clear();
                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n");
                                                                                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                            flameMovementM21.Stop();
                                                                                                            flameMovementM21.Dispose();
                                                                                                                System.Timers.Timer flameMovementM22 = new(0500);//instatiates new timer called flameDuration
                                                                                                                flameMovementM22.Start();
                                                                                                                flameMovementM22.Elapsed += FlameMovementM22_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                            void FlameMovementM22_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                            {
                                                                                                                Console.Clear();
                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n");
                                                                                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                flameMovementM22.Stop();
                                                                                                                flameMovementM22.Dispose();
                                                                                                                    System.Timers.Timer flameMovementM23 = new(0500);//instatiates new timer called flameDuration
                                                                                                                    flameMovementM23.Start();
                                                                                                                    flameMovementM23.Elapsed += FlameMovementM23_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                                void FlameMovementM23_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                {
                                                                                                                    Console.Clear();
                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                    flameMovementM23.Stop();
                                                                                                                    flameMovementM23.Dispose();
                                                                                                                        System.Timers.Timer flameMovementM24 = new(0500);//instatiates new timer called flameDuration
                                                                                                                        flameMovementM24.Start();
                                                                                                                        flameMovementM24.Elapsed += FlameMovementM24_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                    void FlameMovementM24_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                    {
                                                                                                                        Console.Clear();
                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                                        Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                        flameMovementM24.Stop();
                                                                                                                        flameMovementM24.Dispose();
                                                                                                                            System.Timers.Timer flameMovementM25 = new(0500);//instatiates new timer called flameDuration
                                                                                                                            flameMovementM25.Start();
                                                                                                                            flameMovementM25.Elapsed += FlameMovementM25_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                                        void FlameMovementM25_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                        {
                                                                                                                            Console.Clear();
                                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n");
                                                                                                                            Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                            flameMovementM25.Stop();
                                                                                                                            flameMovementM25.Dispose();
                                                                                                                                System.Timers.Timer flameMovementM26 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                flameMovementM26.Start();
                                                                                                                                flameMovementM26.Elapsed += FlameMovementM26_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                                            void FlameMovementM26_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                            {
                                                                                                                                Console.Clear();
                                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                                Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                flameMovementM26.Stop();
                                                                                                                                flameMovementM26.Dispose();
                                                                                                                                    System.Timers.Timer flameMovementM27 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                    flameMovementM27.Start();
                                                                                                                                    flameMovementM27.Elapsed += FlameMovementM27_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                                                void FlameMovementM27_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                {
                                                                                                                                    Console.Clear();
                                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                                    Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                    flameMovementM27.Stop();
                                                                                                                                    flameMovementM27.Dispose();
                                                                                                                                        System.Timers.Timer flameMovementM19 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                        flameMovementM19.Start();
                                                                                                                                        flameMovementM19.Elapsed += FlameMovementM19_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                                    void FlameMovementM19_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                    {
                                                                                                                                        Console.Clear();
                                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                                        Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                        flameMovementM19.Stop();
                                                                                                                                        flameMovementM19.Dispose();
                                                                                                                                            System.Timers.Timer flameMovementM20 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                            flameMovementM20.Start();
                                                                                                                                            flameMovementM20.Elapsed += FlameMovementM20_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                                                        void FlameMovementM20_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                        {
                                                                                                                                            Console.Clear();
                                                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
                                                                                                                                            Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                            flameMovementM20.Stop();
                                                                                                                                            flameMovementM20.Dispose();
                                                                                                                                                System.Timers.Timer flameMovementM21 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                flameMovementM21.Start();
                                                                                                                                                flameMovementM21.Elapsed += FlameMovementM21_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                                                            void FlameMovementM21_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                            {
                                                                                                                                                Console.Clear();
                                                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                flameMovementM21.Stop();
                                                                                                                                                flameMovementM21.Dispose();
                                                                                                                                                    System.Timers.Timer flameMovementM22 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                    flameMovementM22.Start();
                                                                                                                                                    flameMovementM22.Elapsed += FlameMovementM22_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                                                                void FlameMovementM22_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                {
                                                                                                                                                    Console.Clear();
                                                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                    Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                    flameMovementM22.Stop();
                                                                                                                                                    flameMovementM22.Dispose();
                                                                                                                                                        System.Timers.Timer flameMovementM23 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                        flameMovementM23.Start();
                                                                                                                                                        flameMovementM23.Elapsed += FlameMovementM23_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                                                    void FlameMovementM23_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                    {
                                                                                                                                                        Console.Clear();
                                                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                        Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                                        Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                        flameMovementM23.Stop();
                                                                                                                                                        flameMovementM23.Dispose();
                                                                                                                                                            System.Timers.Timer flameMovementM24 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                            flameMovementM24.Start();
                                                                                                                                                            flameMovementM24.Elapsed += FlameMovementM24_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                                                                        void FlameMovementM24_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                        {
                                                                                                                                                            Console.Clear();
                                                                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                            Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                                                            Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                            Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                            flameMovementM24.Stop();
                                                                                                                                                            flameMovementM24.Dispose();
                                                                                                                                                                System.Timers.Timer flameMovementM25 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                                flameMovementM25.Start();
                                                                                                                                                                flameMovementM25.Elapsed += FlameMovementM25_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                                Console.ReadLine();     //keeping console running
                                                                                                                                                            void FlameMovementM25_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                            {
                                                                                                                                                                Console.Clear();
                                                                                                                                                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                                Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                                                Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                                Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                                flameMovementM25.Stop();
                                                                                                                                                                flameMovementM25.Dispose();
                                                                                                                                                                    System.Timers.Timer flameMovementM26 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                                    flameMovementM26.Start();
                                                                                                                                                                    flameMovementM26.Elapsed += FlameMovementM26_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                                    Console.ReadLine();     //keeping console running
                                                                                                                                                                void FlameMovementM26_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                                {
                                                                                                                                                                    Console.Clear();
                                                                                                                                                                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                                    Console.WriteLine("              *    \n            ***     \n            ****   \n            *****  \n             ***  \n              *    \n              *    "); //flame position b
                                                                                                                                                                    Console.WriteLine("   ***********************\n   ***********************\n   ***********************\n\n");
                                                                                                                                                                    Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                                    flameMovementM26.Stop();
                                                                                                                                                                    flameMovementM26.Dispose();
                                                                                                                                                                        System.Timers.Timer flameMovementM27 = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                                        flameMovementM27.Start();
                                                                                                                                                                        flameMovementM27.Elapsed += FlameMovementM27_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                                        Console.ReadLine();     //keeping console running
                                                                                                                                                                    void FlameMovementM27_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                                    {
                                                                                                                                                                        Console.Clear();
                                                                                                                                                                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                                        Console.WriteLine("              *    \n             ***    \n             ****  \n            *****  \n             ***  \n              *    \n              *    "); //flame position a
                                                                                                                                                                        Console.WriteLine("   ***********************\n   ***********************\n\n");
                                                                                                                                                                        Console.WriteLine("ooo..Smells nice!" + " Is that... " + scent + "?\n\n" + "Lets take a moment to enjoy it.\n");
                                                                                                                                                                        flameMovementM27.Stop();
                                                                                                                                                                        flameMovementM27.Dispose();
                                                                                                                                                                            System.Timers.Timer flameDurationL = new(0500);//instatiates new timer called flameDuration
                                                                                                                                                                            flameDurationL.Start();
                                                                                                                                                                            flameDurationL.Elapsed += FlameDurationL_Elapsed; // says once timer is elapsed go to FlameDuration_Elapsed function
                                                                                                                                                                            Console.ReadLine();     //keeping console running
                                                                                                                                                                        void FlameDurationL_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                                                                                                                                                                        {
                                                                                                                                                                            Console.Clear();
                                                                                                                                                                            lit = false;
                                                                                                                                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                                                                                                                                                                            Console.WriteLine("              *    \n              *    ");
                                                                                                                                                                            Console.WriteLine("   ***********************\n   ***********************\n\n");
                                                                                                                                                                            Console.WriteLine("Your candle went out.\n");
                                                                                                                                                                            Console.WriteLine("Hit Enter, If you would like to make another candle at the main menu.");
                                                                                                                                                                            flameDurationL.Stop();
                                                                                                                                                                        }
                                                                                                                                                                        flameDurationL.Stop();
                                                                                                                                                                        flameDurationL.Dispose();



                                                                                                                                                                    }



                                                                                                                                                                }



                                                                                                                                                            }



                                                                                                                                                        }
                                                                                                                                                    }


                                                                                                                                                }

                                                                                                                                            }



                                                                                                                                        }



                                                                                                                                    }





                                                                                                                                }



                                                                                                                            }



                                                                                                                        }



                                                                                                                    }
                                                                                                                }


                                                                                                            }

                                                                                                        }



                                                                                                    }



                                                                                                }



                                                                                            }



                                                                                        }
                                                                                    }


                                                                                }

                                                                            }




                                                                        }



                                                                    }



                                                                }



                                                            }
                                                        }


                                                    }

                                                }



                                            }



                                        }



                                    }



                                }
                            }


                        }

                    }



                }

            }


            catch (NullReferenceException)
            {
                Console.Clear();
                Console.WriteLine("Must enter a candle size (small,medium,large) before you light your candle. Hit enter to return to the menu.");
                Console.ReadLine();
            }
           
        }




        public void PutMeOut()
        {
            Console.Clear();
            lit = false;
            Console.WriteLine("You put the candle out");
            Console.ReadLine();
        }

    }

}