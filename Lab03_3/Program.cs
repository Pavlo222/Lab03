using System;
using System.IO;

namespace Lab03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("C:\\Users\\Вульчак Павло\\Desktop\\input.txt");
            StreamWriter fg = new StreamWriter("C:\\Users\\Вульчак Павло\\Desktop\\output.txt");
            int s = 0, i = 0;
            string str = f.ReadLine();
            f.Close();
            Console.WriteLine("Текст з текстового документа input.txt: \n" + str);
            char[] c = new char[100];
            var chars = str.ToCharArray();
            Console.WriteLine("В текстовий документ output.txt, записуються текст без слiв палiндромiв :");
            foreach (char x in chars)
            {
                if (x == ' ' || x == ',' || x == '.' || x == '!' || x == ';' || x == ':' || x == '"' || x == '/')
                {
                    s = 1;
                }
                if (s != 1)
                {
                    c[i] = x;
                    i++;
                }

                if (s == 1)
                {
                    char[] d = new char[i];
                    char[] e = new char[i];
                    char[] de = new char[i];
                    for (int j = 0; j < i; j++)
                    {
                        d[j] = char.ToLower(c[j]);
                        e[j] = char.ToLower(c[j]);
                        de[j] = c[j];
                    }
                    
                    Array.Reverse(d);
                    int q = 0, qs = 1;
                    while (q < i && qs == 1)
                    {
                        if (d[q] == e[q])
                        {
                            qs = 1;
                        }
                        else
                        {
                            qs = 0;
                        }
                        q++;
                    }
                    if (q != i)
                    {
                        foreach (var z in de)
                        {
                            Console.Write(z);
                            fg.Write(z);
                        }
                        Console.Write(x);
                        fg.Write(x);
                    }
                    i = 0;
                    s = 0;
                }
            }
            fg.Close();
        }
    }
}
