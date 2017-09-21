using System;


    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Creating array");
            string[] str= new string[10];
            str[0]="ssr";
            str[1]="sweety";
            str[2]="reddy";
            str[3]="sumanth";
            str[4]="deepika";
            str[5]="dsreddy";
            for(i=0;i<5;i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine("Created array displayed above");
            Console.WriteLine("Enter string name to search from above array");
            String str2 = Console.ReadLine();
            int j=0;
            for(i=0;i<5;i++)
            {
                if(str2==str[i])
                {
                    j=1;
                        if(j==1)
                    {
                    Console.WriteLine("matched string is "+ str[i]);
                    }
                   
                }
            }
            Console.WriteLine("Copied new array");
            string[] newstr=new string[5];
            for(i=0;i<5;i++)
            {
                newstr[i] = str[i];
                Console.WriteLine(newstr[i]);

            }
            Console.WriteLine("Sorted array");
            Array.Sort(newstr,StringComparer.InvariantCulture);
            for(i=0;i<5;i++)
            {
                Console.WriteLine(newstr[i]);
            }
            i =newstr.Length;
            Console.WriteLine(i);


            
            

        }
    }

