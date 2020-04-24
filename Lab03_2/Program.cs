using System;
using System.IO;

namespace Lab03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("C:\\Users\\Вульчак Павло\\Desktop\\lab.txt");
            int e = 0, y = 0, u = 0, i = 0, o = 0, a = 0,ji=0,je=0,ja=0,jy=0;
            string s = f.ReadLine();
            Console.WriteLine(" " + s);
            var chars = s.ToCharArray();
            foreach(char c in chars)
            {
                switch(c)
                {
                    case 'у': y++; break;
                    case 'е': e++; break;
                    case 'ї': ji++; break;
                    case 'i': i++; break;
                    case 'а': a++; break;
                    case 'о': o++; break;
                    case 'є': je++; break;
                    case 'я': ja++; break;
                    case 'и': u++; break;
                    case 'ю': jy++; break;
                    case 'У': y++; break;
                    case 'Е': e++; break;
                    case 'Ї': ji++; break;
                    case 'I': i++; break;
                    case 'А': a++; break;
                    case 'О': o++; break;
                    case 'Є': je++; break;
                    case 'Я': ja++; break;
                    case 'Ю': jy++; break;
                }
            }
            Console.WriteLine("Кiлькiсть входжень рiзних голосних букв в текстi: ");
            Console.WriteLine("у = " + y);
            Console.WriteLine("е = " + e);
            Console.WriteLine("ї = " + ji);
            Console.WriteLine("i = " + i);
            Console.WriteLine("а = " + a);
            Console.WriteLine("о = " + o);
            Console.WriteLine("є = " + je);
            Console.WriteLine("я = " + ja);
            Console.WriteLine("и = " + u);
            Console.WriteLine("ю = " + jy);
            f.Close();

        }
    }
}
