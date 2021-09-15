using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace test_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ////var files = new DirectoryInfo(@"C:\Users\wshad\Desktop\выбор").GetFiles().Select(f=>Path.GetFileNameWithoutExtension(f.Name)).ToList();
            ////foreach (var file in files)
            ////{
            ////    Console.WriteLine(file);
            ////}
            //string[] mas = { "ww", "ee", "qqqqqq", "qwe", "eewq", "qqqqqq" };
            ////var sss = from ma in mas where ma.EndsWith("q") orderby ma select ma;

            //var sss = mas.Where(ma => ma.EndsWith("q")).Distinct().ToArray();


            //foreach (var s in sss)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.ReadLine();

            //Linq8();
            //Linq9();
            //Linq10();
            //Linq11();
            //Linq12();
            Console.WriteLine(Linq13());
            Console.ReadLine();
        }
        private void Run()
        {
            List<string> a = new List<string>();
            Test(ref a);
            Console.WriteLine(a[0]);
        }

        private void Test(ref List<string> a)
        {
            a = null;
        }

        static void Linq1()
        {
            //////// 1.
            int[] nums = { -4, 1, -5, 120, 67, 9, 0, -7, 22 };
            Console.WriteLine(nums.FirstOrDefault(a => a >= 0) + "\n" + nums.LastOrDefault(a => a < 0));
        }
        static void Linq2()
        {
            ////  2.
            var q = 9;
            int[] qq = { 12, -4, -29, 68, 89, 66674229, -67, 69 };
            //LinqBegin2. Дана цифра D(однозначное целое число) и целочисленная последовательность A.
            //Вывести количество элемент последовательности A, оканчивающийся
            //цифрой D. Если требуемых элементов в последовательности
            //A нет, то вывести -2.

            // var g = qq.Count(w => w % 10 == q);
            var t = qq.Count(w => w % 10 == q) > 0 ? qq.Count(w => w % 10 == q) : -2;
            Console.WriteLine(t);
        }
        static void Linq3()
        {
            ////3.
            ////Дано целое число L(> 0) и строковая последовательность A.
            ////Вывести последнюю строку из A, начинающуюся с цифры и имеющую длину L.
            ////Если требуемых строк в последовательности A нет, то вывести строку «Not found». 

            ////Указание.Для обработки ситуации, связанной с отсутствием
            ////требуемых строк, использовать операцию ??.

            var l = 4;
            string[] a = { "wer", "gfkngis", "1ghd", "tttt", "6754", "7tyu", "jbfwufveruw", "nfi" };

            //var gg = a.LastOrDefault(s => s.Length == l && int.TryParse(s.First().ToString(), out _)) ?? "Not found";

            var i = a.Where(u => u.Length == l && int.TryParse(u.First().ToString(), out _)).Reverse().ToArray();
            Console.WriteLine((i.Any() ? i[0] : null) ?? "Not found");
        }
        static void Linq4()
        {
            ////4.
            ////LinqBegin4. Дан символ С и строковая последовательность A.
            ////    Если A содержит единственный элемент, оканчивающийся
            ////символом C, то вывести этот элемент; если требуемых строк
            ////    в A нет, то вывести пустую строку; если требуемых строк
            ////больше одной, то вывести строку «Error». 
            ////Указание.Использовать try-блок для перехвата возможного
            ////исключения.
            char q = '4';
            string[] qq = { "wer", "gfkngis", "1ghd", "tttt", "6754", "jfbsj4", "7tyu", "jbfwufveruw", "nfi" };
            try
            {
                Console.WriteLine(
                    qq.Count(t => t.EndsWith(q.ToString())) > 1 ?
                        "Error" :
                        qq.Where(t => t.EndsWith(q.ToString())).ToList()[0].Last().ToString());
            }
            catch
            {
                Console.WriteLine("");
            }
        }
        static void Linq5()
        {
            //// 5.
            ////LinqBegin5.Дан символ С и строковая последовательность A.
            ////Найти количество элементов A, которые содержат более одного символа и при этом начинаются и оканчиваются символом C

            char c = '4';
            string[] a = { "wer", "gfkngis", "j", "o", "1ghd", "4jj4", "tttt", "6754", "jfbsj4", "44", "7tyu", "jbfwufveruw", "nfi" };

            Console.WriteLine(a.Count(d => d.Length > 1 && d.StartsWith(c.ToString()) && d.EndsWith(c.ToString())).ToString());
            Console.WriteLine(a.Where(d => d.Length > 1).Where(v => v.EndsWith(c.ToString())).Where(n => n.StartsWith(c.ToString())).Count().ToString());
            
        }
        static void Linq6()
        {
            ////// 6.
            //// LinqBegin6. Дана строковая последовательность. Найти сумму 
            ////длин всех строк, входящих в данную последовательность. 

            var a = new List<string> { "wer", "gfkngis", "j", "o", "1ghd" };
            Console.WriteLine(a.Sum(d => d.Length));
            
        }
        static void Linq7()
        {
            //// 7.
            ////LinqBegin7.Дана целочисленная последовательность.Найти
            ////    количество ее отрицательных элементов, а также их сумму. 
            ////    Если отрицательные элементы отсутствуют, то дважды вывести 0

            List<int> qq = new List<int>() { 1, 3, 55, 689, -7, -67, 66 - 3 };

            Console.WriteLine(qq.Count(n => n < 0) + "\n" + qq.Where(n => n < 0).Sum());
            
        }
        static void Linq8()
        {
            //8.
            //LinqBegin8.Дана целочисленная последовательность.Найти 
            //    количество ее положительных двузначных элементов, а также их среднее арифметическое(как вещественное число). 
            //Если требуемые элементы отсутствуют, то дважды вывести 0
            //    (первый раз как целое, второй — как вещественное).

            List<int> qq = new List<int>() { 1, 3, 55, 689, -7, -67, 66, - 3 };
            var t = qq.Where(q => q > 9 && q < 100).ToList();
            Console.WriteLine(t.Count + "\n" + (t.Count > 0 ? t.Average().ToString() : $"{(double) 0:C1}"));
        }

        static void Linq9()
        {
            //LinqBegin9.Дана целочисленная последовательность.Вывести
            //    ее минимальный положительный элемент или число 0, если
            //    последовательность не содержит положительных элементов. 
            List<int> qq = new List<int>() { 1, 3, 55, 689, -7, -67, -3 };
            Console.WriteLine(qq.Any(q => q > 0)  ? qq.Where(q => q > 0).Min().ToString() : "0");
        }

        static void Linq10()
        {
            //LinqBegin10.Дано целое число L(> 0) и строковая последовательность A. Строки последовательности A содержат только
            //    заглавные буквы латинского алфавита.Среди всех строк из
            //    A, имеющих длину L, найти наибольшую(в смысле лексикографического порядка). Вывести эту строку или пустую
            //    строку, если последовательность не содержит строк длины L. 

            int l = 4;
            var a = new List<string>{ "JJJ", "DF"/*"JOUTP", "OIUY","ZTYU","ZZTY", "FDSA"*/ };
            //Console.WriteLine(a.Any(q=>q.Length==l) ? a.Where(q=>q.Length==l ).OrderByDescending(q=>q).FirstOrDefault():"ybbsf");
            Console.WriteLine(a.Where(q => q.Length == l).OrderByDescending(q => q).FirstOrDefault());
        }

        static void Linq11()
        {
            //LinqBegin11.Дана последовательность непустых строк. 
            //    Используя метод Aggregate, получить строку, 
            //состоящую из начальных символов всех строк исходной последовательности. 
            string[] a = { "wer", "gfkngis", "j", "o", "1ghd", "4jj4", "tttt", "6754", "jfbsj4", "44", "7tyu", "jbfwufveruw", "nfi" };
            Console.WriteLine(a.Aggregate((x, y) => x + y.First().ToString()));

        }

        static void Linq12()
        {
            //LinqBegin12.Дана целочисленная последовательность.Используя метод Aggregate, найти произведение последних
            //цифр всех элементов последовательности.Чтобы избежать
            //целочисленного переполнения, при вычислении произведения использовать вещественный числовой тип.
            List<int> qq = new List<int>() { 1, 3, 55, 689, -7, -67, 66, -3 };
            Console.WriteLine(qq.Aggregate((x, y) => x * y.ToString().Last()));
            //????????????????????????
        }
        static double Linq13()
        {
            //LinqBegin13.Дано целое число N(> 0). Используя методы
            //Range и Sum, найти сумму 1 + (1 / 2) + … +(1 / N)(как вещественное число).
            var n = 5;
            double sum = 0;
            IEnumerable<int> rr = Enumerable.Range(1, n);
            foreach (var i in rr)
            {
                sum = sum + 1 / i;
            }

            return sum;
        }
        
    }
}
  