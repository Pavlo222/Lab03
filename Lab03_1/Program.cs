using System;

namespace Lab03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0, i = 0, s = 0, d = 0, doz = 0, sq = 0, sp = 0, sd = 0, bz = 0;
            Console.WriteLine("Введiть текст:");
            string str = Console.ReadLine();
            Console.WriteLine("Введений текст: " + str);
            var chars = str.ToCharArray();
            foreach (var c in chars)
            {
                
                if (char.IsNumber(c))
                {
                    digit++;
                }
                i++;
            }
            Console.WriteLine("Кiлькiсть цифр у текстi: {0}",digit);
            Console.WriteLine("Слова, що починаються з приголосних лiтер :");
            foreach(var x in chars)
            {
                switch (x)
                {
                    case ' ': s = 1;sp = 1; break;
                    case 'й': d = 1; break;
                    case 'ц': d = 1; break;
                    case 'к': d = 1; break;
                    case 'н': d = 1; break;
                    case 'г': d = 1; break;
                    case 'ш': d = 1; break;
                    case 'щ': d = 1; break;
                    case 'з': d = 1; break;
                    case 'х': d = 1; break;
                    case 'ф': d = 1; break;
                    case 'в': d = 1; break;
                    case 'п': d = 1; break;
                    case 'р': d = 1; break;
                    case 'л': d = 1; break;
                    case 'д': d = 1; break;
                    case 'ж': d = 1; break;
                    case 'ч': d = 1; break;
                    case 'с': d = 1; break;
                    case 'м': d = 1; break;
                    case 'т': d = 1; break;
                    case 'б': d = 1; break;
                    case 'ґ': d = 1; break;
                    case 'Й': d = 1; break;
                    case 'Ц': d = 1; break;
                    case 'К': d = 1; break;
                    case 'Н': d = 1; break;
                    case 'Г': d = 1; break;
                    case 'Ш': d = 1; break;
                    case 'Щ': d = 1; break;
                    case 'З': d = 1; break;
                    case 'Х': d = 1; break;
                    case 'Ф': d = 1; break;
                    case 'В': d = 1; break;
                    case 'П': d = 1; break;
                    case 'Р': d = 1; break;
                    case 'Л': d = 1; break;
                    case 'Д': d = 1; break;
                    case 'Ж': d = 1; break;
                    case 'Ч': d = 1; break;
                    case 'С': d = 1; break;
                    case 'М': d = 1; break;
                    case 'Т': d = 1; break;
                    case 'Б': d = 1; break;
                    case 'Ґ': d = 1; break;
                }
               
                if(sq==0&&d==1)
                {
                    doz = 1;
                }
                if(s==1)
                {
                    bz = 0;
                    if (sp == 1)
                    {
                        if(doz==1)
                        {
                            bz = 1;
                        }
                        d = 0;
                        if(bz==1)
                        {
                            Console.Write(" ");
                        }
                        sp = 0;
                        sd = 0;
                    }
                    doz = 0;
                    if (d==1&&sd<2)
                    {
                        doz = 1;
                        s = 0;
                    }
                    sd++;
                }
                
                if(doz==1&&char.IsLetter(x))
                {
                    Console.Write(x);
                }
                sq++;
            }
        }
    }
}
