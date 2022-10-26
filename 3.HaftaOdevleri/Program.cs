using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3.HaftaOdevleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calistir = true;

            Console.WriteLine("1 = Uygulama 1");
            Console.WriteLine("2 = Uygulama 2");
            Console.WriteLine("3 = Uygulama 3");
            Console.WriteLine("4 = Uygulama 4");
            Console.WriteLine("5 = Uygulama 5");
            Console.WriteLine("6 = Uygulama 6");
            bas:
            Console.Write("Çaşıltırmak istediğiniz uygulmayayı seçiniz:");
            byte sayi = Convert.ToByte(Console.ReadLine());
            
            switch (sayi)
            {
                case 1:
                    
                    Console.WriteLine("48/6/4 = " + 48/6/4);
                    Console.WriteLine("24/3*2 = " + 24/3*2);
                    Console.WriteLine("2^2+5-1+4 = " + (Math.Pow(2.0, 2.0)+5-1+4));
                    Console.WriteLine("(7+4)*2-1+8/2 = " + ((7 + 4) * 2 - 1 + 8 / 2));
                    Console.WriteLine("(5-1)*2-1+7^2/2 = " + ((5 - 1) * 2 - 1 + Math.Pow(7,2) / 2));
                   
                    break;

                case 2:

                    if (calistir)
                    {
                        int x = 20;
                        int y = 13;
                        int z = 24;
                        bool a = 23 == 55 && 76 > 45 && 5 < 12;
                        bool b = 23 >= 23 && 45 != 18;
                        bool c = x > y && z == y && z < x ;
                        bool d = z > x && y < x;
                        bool e = x != z || y <= z;
                        Console.WriteLine("23 == 55 && 76 > 45 && 5 < 12 işlemininin sonucu: " + a);
                        Console.WriteLine("23 >= 23 && 45!= 18 işleminin sonucu: " + b);
                        Console.WriteLine("x=20 , y=13 ve z=42 olmak üzere;");
                        Console.WriteLine("x > y && z == y && z < x işleminin sonucu: " + c);
                        Console.WriteLine("z > x && y < x işleminin sonucu: " + d);
                        Console.WriteLine("x != z || y <= z işleminin sonucu: " + e);
                    }
                    

                    break;

                case 3:

                    if (calistir)
                    {
                         Console.Write("İlk sayıyı giriniz:");
                         int sayi1 = Convert.ToInt32(Console.ReadLine());
                         Console.Write("İkinci sayıyı giriniz:");
                         int sayi2 = Convert.ToInt32(Console.ReadLine());
                         int bolum = sayi1 % sayi2;
        
                            if (bolum == 0)
                            {
                                 Console.WriteLine("İlk Sayı ikinci sayıya kalansız bölünebilir."); 
                            }
                           else
                           {
                               Console.WriteLine("İlk Sayı ikinci sayıya kalansız bölünememektedir.");
                           }
                    }


                    break;

                case 4:

                    if (calistir)
                    {
                         string gün, ay, yil;
                         Console.Write("Günü Giriniz: ");
                         Console.Write("Ayı Giriniz: ");
                         Console.Write("Yılı Giriniz: ");
                         gün = Convert.ToString(Console.ReadLine());
                         ay =  Convert.ToString(Console.ReadLine());
                         yil = Convert.ToString(Console.ReadLine());

                        switch (ay)
                        {
                            case "1":
                                 ay = "Ocak";
                                break;

                            case "2":
                                 ay = "Şubak";
                                break;

                            case "3":
                                 ay = "Mart";
                                break;

                            case "4":
                                 ay = "Nisan";
                                break;

                            case "5":
                                 ay = "Mayıs";
                                break;

                            case "6":
                                 ay = "Haziran";
                                break;

                            case "7":
                                 ay = "Temmuz";
                                break;

                            case "8":
                                 ay ="Ağustos";
                                break;

                            case "9":
                                 ay = "Eylül";
                                break;

                            case "10":
                                 ay = "Ekim";
                                break;

                            case "11":
                                 ay = "Kasım";
                                break;

                            case "12":
                                 ay = "Aralık";
                                break;

                            default:
                                Console.WriteLine("Hatalı Veri Girişi");
                                break;
                        }
                        Console.Write(gün + " " + ay + " " + yil);
                    }

                    break;

                case 5:

                    if (calistir)
                    {
                        Console.Write("A Değerini Giriniz = ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("B Değerini Giriniz = ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("C Değerini Giriniz = ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        double d = (b * b) - (4 * a * c);
                        if (d > 0)
                        {
                            double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                            double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                            Console.WriteLine("Denklemin İki Kökü Vardır = ");
                            Console.WriteLine("x1 =" + x1);
                            Console.WriteLine("x2 =" + x2);
                        }
                        else if (d == 0)
                        {
                            double x = -b / (2 * a);
                            Console.WriteLine("Denklemin Bir Kökü Vardır = ");
                            Console.WriteLine("x =" + x);
                        }
                        else
                        {
                            Console.Write("Sanal Kök Vardır");
                        }
                    }

                    break;

                case 6:

                    if (calistir)
                    {
                        Console.Write("Derece değerini giriniz : ");

                        int D = Convert.ToInt32(Console.ReadLine());

                        double R = D * Math.PI / 180;

                        double G = D * 200 / 180;

                        Console.WriteLine("derecenin radyan cinsinden değeri = {0} ", R);

                        Console.Write("derecenin grad cinsinden değeri = {0}", G);

                    }

                    break;

                default: 
                      Console.WriteLine("En başta belirtilen sayılardan başka değer girmeyiniz.");
                      goto bas;
                    break;
            }


            Console.Read();
        }
    }
}
