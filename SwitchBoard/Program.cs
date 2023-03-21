using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard
{
    internal class Program
    {
        public static int IsInt(string str)
        {
            int q;
            while (true)
            {
                Console.WriteLine(str);
                if(int.TryParse(Console.ReadLine(), out q))
                    break;
                Console.WriteLine("Invalid Input.");
            }
            return q;
        }

        public static void Display(List<Appliance> appliances)
        {
            int count = 0;
            foreach (var i in appliances)
            {
                Console.WriteLine(++count + " " + i.Name + " " + i.Id + " " + (i.Status ? " ON" : " OFF"));
            }
        }
        static void Main(string[] args)
        {
            int l, m, n, o;
            List<Appliance> appliances = new List<Appliance>();
            try
            {
                m = IsInt("Number of Fans");
                n = IsInt("Number of AC");
                o = IsInt("Number of Bulb");

                l = m + n + o;

                for(int i = 0; i < l; i++)
                {
                    if (i < m)
                        appliances.Add(new Appliance(i, "Fan", false));
                    else if(i < m+n)
                        appliances.Add(new Appliance(i, "AC", false));
                    else
                        appliances.Add(new Appliance(i, "Bulb", false));
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Input Mismatch");
                Console.WriteLine(ex.ToString());
            }

            while (true)
            {
                Display(appliances);
                int sel = IsInt("Select Device");

                Console.WriteLine("1. Switch " + appliances[sel - 1].Name + " " + appliances[sel - 1].Id + " " + (appliances[sel - 1].Status ? " OFF" : " ON"));
                Console.WriteLine("2. Back");

                int ch = IsInt("Enter the right choice");
                switch (ch)
                {
                    case 1:
                        appliances[sel - 1].Status = appliances[sel - 1].Status ? false : true;
                        break;
                    case 2:
                        break;
                }
                int sl = 0;
                Display(appliances);
                Console.WriteLine();
            }
        }
    }
}