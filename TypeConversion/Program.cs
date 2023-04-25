﻿namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d : " + d);
            long h = d;
            Console.WriteLine("h : " + h);
            float i = h;
            Console.WriteLine("i : " + i);
            string e = "patika";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g : " + g);

            //Explicit Conversion (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            float z = 10.3f;
            byte w = (byte)z;
            Console.WriteLine("w : " + w);

            //ToString() Metodu
            int xx = 5;
            string yy =xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + toplam);

            //Parse
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double rakam2;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("Rakam1 : " + rakam1);
            rakam2 = Double.Parse(metin2);
            Console.WriteLine("Rakam2 : " + rakam2);
        }
    }
}