using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
            //Console.WriteLine(Linq17());
            //Linq18();
            //Linq19();
            //Linq20();
            //Linq21();
            //Linq22();
            //Linq23();
            //Linq24();
            //Linq25();
            //Linq26();
            //Linq27();
            //Linq28();
            //Linq29();
            //Linq30();
            //Linq31();
            //Linq32();
            //Linq33();
            //Linq34();
            //Linq35();
            //Linq37();
            //Linq39();
            //Linq42();
            //Linq45();
            //Linq46();
            Linq50();
            //Linq45();
            //Linq45();
            //Linq45();

            //Test();
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
            //Console.WriteLine(qq.Select(m=> double.Parse(m.ToString())));
           // var ff = qq.Select(m => double.Parse(m.ToString()));
           // Console.WriteLine(qq.Select(m => double.Parse(m.ToString())).Aggregate((x, y) =>  x * double.Parse(y.ToString().Last().ToString())));
            Console.WriteLine(qq.Select(m => double.Parse(m.ToString())).Aggregate((x, y) => x * double.Parse(y.ToString().Last().ToString())));
            //????????????????????????
        }

        static double Linq13()
        {
            //LinqBegin13.Дано целое число N(> 0). Используя методы
            //Range и Sum, найти сумму 1 + (1 / 2) + … +(1 / N)(как вещественное число).

            var n = -5;
            var rr = 1 + Enumerable.Range(1, n).Sum(p => (double)1 / p);
            return rr;

            string[] dd = {"1.2", "3,7", "4", "5.368", "4677", "23"};
            var gg = dd.Select(s =>double.Parse(s.Replace('.', ',')));
            foreach (var s in gg)
            {
               Console.WriteLine(s.GetTypeCode());
            }
        }
        static double Linq14()
        {
            //LinqBegin14.Даны целые числа A и B(A<B). Используя методы Range и Average,
            //найти среднее арифметическое квадратов всех целых чисел от A до B включительно:
            //(A2 + (A + 1)2 + … +B2)/ (B − A + 1) (как вещественное число). 

            int a = 5;
            int b = 9;
            var p = Enumerable.Range(a, 5).Average(r=>Math.Pow(r, 2))/(b-a+1);
            return p;
        }
        static double Linq15()
        {
            //LinqBegin15.Дано целое число N(0 ≤ N ≤ 15). Используя методы Range и Aggregate, 
            //найти факториал числа N://N! = 1·2·…·N при N ≥ 1; 0! = 1.Чтобы избежать целочисленного переполнения,
            //при вычислении факториала использовать вещественный числовой тип. 


            return 8;
        }
        static void Linq16()
        {
            //LinqBegin16.Дана целочисленная последовательность.Извлечь из нее все положительные числа, 
            //    сохранив их исходный порядок следования.
            List<int> qq = new List<int>() { 1, 67, 3, 55, 689, -7, -67, 66 - 3 };
            var t = qq.Where(g => g > 0).OrderBy(h=>h).ToArray();
            foreach (var i in t)
            {
                 Console.WriteLine(i);
            }
            
        }
        static void Linq17()
        {
            //LinqBegin17.Дана целочисленная последовательность.Извлечь из нее все нечетные числа, 
            //    сохранив их исходный порядок следования и удалив все вхождения повторяющихся
            //    элементов, кроме первых.
           List<int> qq = new List<int>() { 1, 67, 3, -40, 55, 689, -40, 40, 66, -7, -67, -40, 66, 64, - 3 };
            var t = qq.Where(g => g %2 ==0).Distinct().ToArray();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
            
        }

        static void Linq18()
        {
            //LinqBegin18.Дана целочисленная последовательность. Извлечь из нее все четные отрицательные числа, 
            //поменяв порядок извлеченных чисел на обратный.

            List<int> qq = new List<int>() { 1, 67, 3, -40, 55,-60, 689, -40, 40, 66, -7, -67, -40, 66, 64, -3 };
            var rr = qq.Where(l => l < 0 && l % 2 == 0).Reverse().ToList();
            foreach (var i in rr)
            {
                Console.WriteLine(i);
            }

        }
        static void Linq19()
        {
            //LinqBegin19.Дана цифра D(целое однозначное число) и целочисленная последовательность A.
            //    Извлечь из A все различные положительные числа, оканчивающиеся цифрой D(в исходном порядке). 
            //При наличии повторяющихся элементов удалять все их вхождения, кроме последних.
            //    Указание.Последовательно применить методы Reverse,
            //    Distinct, Reverse

            int d = 7;
            List<int> a = new List<int>() { 1, 67, 3, -40, 55, -60, 689, 40,7, 67, 66, -7, -67, 66, 64, -3 };
            //Thread.Sleep(new TimeSpan(0,19,0,0));
            var t = a.Where(s => s > 0 && s.ToString().Last().ToString() == d.ToString()).Reverse().Distinct().Reverse();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq20()
        {
            //LinqBegin20.Дана целочисленная последовательность.
            //    Извлечь из нее все положительные двузначные числа, отсортировав их по возрастанию
            List<int> a = new List<int>() { 1, 67, 3, -40, 55, -60, 689, 40, 7, 67, 66, -7, -67, 66, 64, -3 };
            var k = a.Where(g => g>9 && g < 100).OrderBy(r=>r).ToList();
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq21()
        {
            //LinqBegin21.Дана строковая последовательность.Строки последовательности содержат только заглавные буквы 
            //    латинского алфавита. Отсортировать последовательность по возрастанию длин строк, 
            //    а строки одинаковой длины — в лексикографическом порядке по убыванию

            List<string> a = new List<string>() {"FGHJ", "OIE", "AAAA","DHSFD", "PORU", "FG", "FBFSGBDYFGSDF" };
            var k = a.OrderBy(g => g.Length).ThenByDescending(g=>g).ToList();
            foreach (var i in k)
            {
                Console.WriteLine(i);
            }
            
        }
        static void Linq22()
        {
            //LinqBegin22.Дано целое число K(> 0) и строковая последовательность A. Строки последовательности содержат только
            //цифры и заглавные буквы латинского алфавита. Извлечь из A все строки длины K, оканчивающиеся цифрой, отсортировав
            //    их в лексикографическом порядке по возрастанию. 

            int k = 4;
            List<string> a = new List<string>() { "FGHJ","3446", "ZZ67","O55IE","7784", "AAA8", "D6HSFD", "TYU5","66", "PORU", "FG", "FBFSG78BDYFGSDF" };
            var h = a.Where(g => g.Length == k && int.TryParse(g.Last().ToString(), out int result)).OrderBy(g => g).ToList();
            foreach (var i in h)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq23()
        {
            //LinqBegin23.Дано целое число K(> 0) и целочисленная последовательность A. 
            //    Начиная с элемента A с порядковым номером K, извлечь из A все 
            //    нечетные двузначные числа, отсортировав их по убыванию

            int k = 4;
            List<int> a = new List<int>() { 1, 67, 3, -40, 55, -60, 689, 40, 7, 67, 66, -7, -67, 66, 64, -3 };
            var h = a.Skip(k-1).Where(e => e > 9 && e < 100 && e % 2 == 0).OrderByDescending(e => e ).ToList();
            foreach (var i in h)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq24()
        {
            //LinqBegin24.Дано целое число K(> 0) и строковая последовательность A. Из элементов A, 
            //    предшествующих элементу с порядковым номером K, извлечь те строки, которые имеют
            //    нечетную длину и начинаются с заглавной латинской буквы, 
            //    изменив порядок следования извлеченных строк на обратный.

            int k = 9;
            List<string> a = new List<string>() { "FGHJ","Dytrs", "3446","bh907","6754d", "Кувп8", "ZZ67", "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };
            var h = a.Take(k - 1).Where(e => e.Length % 2 == 1 && char.IsUpper(e.First()) && e.First() >= 65 && e.First() <= 90).Reverse().ToList();
            foreach (var i in h)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq25()
        {
            //LinqBegin25.Даны целые числа K1 и K2 и целочисленная последовательность A; 1 ≤ K1 < K2 ≤ N, 
            //где N — размер последовательности A. Найти сумму положительных элементов последовательности 
            //    с порядковыми номерами от K1 до K2 включительно. 

            int k1 = 4;
            int k2 = 8;
            List<int> a = new List<int>() { 1, 67, 3, -40, 55, -60, 689, 40, 7, 67, 66, -7, -67, 66, 64, -3 };
            Console.WriteLine(a.Where(y => a.IndexOf(y) + 1 >= k1 && a.IndexOf(y) + 1 <= k2 && y > 0).Sum().ToString());
            
        }
        static void Linq26()
        {
            //LinqBegin26.Даны целые числа K1 и K2 и последовательность
            //непустых строк A; 1 < K1 < K2 ≤ N, где N — размер последовательности A. Найти среднее арифметическое длин всех
            //элементов последовательности, кроме элементов с порядковыми номерами от K1 до K2 включительно, и вывести его как
            //вещественное число.

            int k1 = 4;
            int k2 = 8;
            List<string> a = new List<string>() { "FGHJ", "Dytrs", "3446", "bh907", "6754d", "Кувп8", "ZZ67", "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };
            var t = a.Where(y => a.IndexOf(y) + 1 <= k1 || a.IndexOf(y) + 1 >= k2).Average(f=>f.Length);
            Console.WriteLine(t);
            
        }
        static void Linq27()
        {
            //LinqBegin27.Дано целое число D и целочисленная последовательность A. Начиная с первого элемента A, 
            //    большего D, извлечь из A все нечетные положительные числа, поменяв порядок извлеченных чисел на обратный

            int d = 4;
            List<int> a = new List<int>() { 1, 2, 67, 3, -40, 55, -60, 689, 40, 7, 67, 66, -7, -67, 66, 64, -3 };  
            var t = a.SkipWhile(f=> f<=d).Where(h=>h>0 && h%2 ==1).Reverse();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq28()
        {
            //LinqBegin28.Дано целое число L(> 0) и последовательность непустых строк A.Строки последовательности содержат
            //    только цифры и заглавные буквы латинского алфавита. Из элементов A, предшествующих первому элементу, 
            //    длина которого превышает L, извлечь строки, оканчивающиеся буквой.
            //    Полученную последовательность отсортировать по убыванию длин строк, а строки одинаковой длины — 
            //в лексикографическом порядке по возрастанию. 

            int l = 5;
            List<string> a = new List<string>() { "FGHJ","ASDFC", "TYU","ASD", "67R", "3446",  "ZZ67",
                "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };
            var t = a.TakeWhile(f => f.Length <= l).Where(h => char.IsLetter(h.Last())).OrderByDescending(s=>s.Length).ThenBy(d => d).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq29()
        {
            //LinqBegin29. Даны целые числа D и K(K > 0) и целочисленная
            //последовательность A. Найти теоретико-множественное объединение двух фрагментов A: первый содержит все элементы
            //до первого элемента, большего D(не включая его), а второй 
            //    — все элементы, начиная с элемента с порядковым номером
            //K.Полученную последовательность(не содержащую одинаковых элементов) отсортировать по убыванию.

            int d = 5;
            int k = 8;
            List<int> a = new List<int>() { 1, 2,  3, 5, -40, 55, -60, 689, 40, 7, 67, 66,1, -7, 2, -67, 66, 64, -3 };
            //var j = a.TakeWhile(f => f < d).ToList();
            //var x = a.Skip(k - 1).ToList();
            var t = a.TakeWhile(f => f < d).Union(a.Skip(k - 1)).OrderByDescending(u => u).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq30()
        {
            //LinqBegin30.Дано целое число K(> 0) и целочисленная последовательность A. 
            //    Найти теоретико-множественную разность двух фрагментов A: первый содержит все четные числа, 
            //а второй — все числа с порядковыми номерами, большими K. В полученной последовательности
            //    (не содержащей одинаковых элементов) поменять порядок элементов на обратный.

            int k = 7;
            List<int> a = new List<int>() { 1, 2, 3, 5, -40, 55, -60, 689, 40, 7, 67, 66, 1, -7, 2, -67, 66, 64, -3 };
            var t = a.Where(d => d % 2 == 0).Except(a.Skip(k + 1)).Reverse().ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq31()
        {
            //LinqBegin31.Дано целое число K(> 0) и последовательность
            //непустых строк A.Строки последовательности содержат
            //    только цифры и заглавные буквы латинского алфавита. Найти теоретико-множественное пересечение двух фрагментов
            //A: первый содержит K начальных элементов, а второй — все
            //    элементы, расположенные после последнего элемента, оканчивающегося цифрой. Полученную последовательность(не
            //    содержащую одинаковых элементов) отсортировать по возрастанию длин строк, а строки одинаковой длины — 
            //в лексикографическом порядке по возрастанию. 

            int k = 5;
            List<string> a = new List<string>() {  "PIUJ","FGH","TT","ASDFC", "TYU","ASD", "67R", "3446",  "ZZ67",
                "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU","TYU", "FG","TT", "PIUJ","FBFSG78BDYFGSDF" ,"FGH"};
            
            var t = a.Take(k).Intersect(((IEnumerable<string>)a).Reverse().TakeWhile(f => !(int.TryParse(f.Last().ToString(), out int result)))).
                OrderBy(f=>f.Length).ThenBy(h=>h).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            } 
        } 
        static void Linq35()
        {
            //LinqBegin35.Дана целочисленная последовательность.Получить последовательность чисел, 
            //    каждый элемент которой равен произведению соответствующего элемента исходной последовательности на его порядковый номер(1, 2, …).
            //В полученной последовательности удалить все элементы, не являющиеся двузначными, и поменять порядок оставшихся элементов на обратный. 


            List<int> a = new List<int>() { 1, 2, 3, 5, -40, 55, -60, 689, 40, 7, 67, 66, 1, -7, 2, -67, 66, 64, -3 };
            var t = a.Select(e => (a.IndexOf(e)+1) * e).Where(s=>Math.Abs(s) > 9 && Math.Abs(s)<100).Reverse().ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq37()
        {
            //LinqBegin37.Дана строковая последовательность A. Строки последовательности содержат только заглавные буквы латинского алфавита. 
            //    Получить новую последовательность строк, элементы которой определяются по соответствующим
            //элементам A следующим образом: пустые строки в новую последовательность не включаются, а к непустым приписывается порядковый номер данной строки 
            //    в исходной последовательности (например, если пятый элемент A имеет вид «ABC», то в полученной последовательности он будет иметь вид «ABC5»).
            //При нумерации должны учитываться и пустые строки последовательности A.
            //    Отсортировать полученную последовательность в лексикографическом порядке по возрастанию.

            int l = 5;
            List<string> a = new List<string>() { "FGHJ","ASDFC","", "TYU","ASD", "DHSFD", "",  "PORU", "FG" };
            var t = a.Select(r => r + (a.IndexOf(r) + 1)).Where(s=>!int.TryParse(s.FirstOrDefault().ToString(), out int num)).OrderBy(e=>e).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq39()
        {
            //LinqBegin39.Дана строковая последовательность A. Получить последовательность цифровых символов, входящих в строки
            //последовательности A(символы могут повторяться). Порядок символов должен соответствовать порядку строк A и порядку следования символов в каждой строке. 
            //    Указание.Использовать метод SelectMany с учетом того, что строка может интерпретироваться как последовательность символов.

            List<string> a = new List<string>() { "FGHJ","ASDFC", "TYU","ASD", "67R", "3446",  "ZZ67",
                "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };

            var t = a.SelectMany(d => d.Where(k=>int.TryParse(k.ToString(), out int fResult))).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i);
            }
        }

        static void Linq42()
        {
            //LinqBegin42.Дана последовательность непустых строк. Получить последовательность символов, которая определяется следующим образом:
            //для строк с нечетными порядковыми номерами(1, 3, …) в последовательность символов включаются все прописные латинские буквы, содержащиеся в этих строках, 
            //а для строк с четными номерами(2, 4, …) — все их строчные латинские буквы.
            //В полученной последовательности символов сохранить их исходный порядок следования.

           List<string> a = new List<string>() { "FGHJ", "Dytrs", "3446", "bh907", "6754d", "Кувп8", "ZZ67", "O55IE", "7784", "еAAA8",
               "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };

            var t = a.Where(f=>(a.IndexOf(f)+1)%2==1).SelectMany(n=> n.ToArray().Where(char.IsUpper) ).ToList();
            var tt = a.Where(f => (a.IndexOf(f) + 1) % 2 == 0).SelectMany(n=>n.ToCharArray().Where(char.IsLower)).ToList();
            var ttt = t.Concat(tt).ToList();
            foreach (var i in ttt)
            {
                Console.WriteLine(i);
            }
        }
        static void Linq45()
        {
            //LinqBegin45.Даны целые положительные числа L1 и L2 и строковые последовательности A и B.Строки последовательностей содержат только цифры 
            //и заглавные буквы латинского алфавита.Получить последовательность, содержащую все строки из A длины L1 
            //и все строки из B длины L2.Отсортировать полученную последовательность в лексикографическом порядке по убыванию.

            int l1 = 6;
            int l2 =2;
            List<string> a = new List<string>() { "FGHJ","ASDFC", "TYU","ASD", "67R", "3446",  "ZZ67",
                "O55IE", "7784", "AAA8", "D6HSFD", "TYU5", "66", "PORU", "FG", "FBFSG78BDYFGSDF" };

            List<string> b = new List<string>(){"SDFG", "23T", "09IFU"};

            var t = a.Take(l1).Concat(b.Take(l2)).OrderByDescending(f => f).ToList();
            foreach (var s in t)
            {
                    Console.WriteLine(s);
            }
        }
        static void Linq46()
        {
            //LinqBegin46.Даны последовательности положительных целых чисел A и B; все числа в каждой последовательности различны.
            //Найти последовательность всех пар чисел, удовлетворяющих следующим условиям:
            //первый элемент пары принадлежит последовательности A, второй принадлежит B, и
            //оба элемента оканчиваются одной и той же цифрой.
            //Результирующая последовательность называется внутренним объединением последовательностей A и B по ключу, 
            //    определяемому последними цифрами исходных чисел.Представить найденное объединение в виде последовательности строк, 
            //    содержащих первый и второй элементы пары, разделенные дефисом, например, «49 - 129». Порядок следования пар должен определяться 
            //исходным порядком элементов последовательности A, а для равных первых элементов — порядком элементов последовательности B

            List<int> a = new List<int>(){87,4,21, 79};
            List<int> b = new List<int>() { 54, 18, 6, 67, 9 };

            var ttt = a.Join(b,  p => p.ToString().Last(), t => t.ToString().Last(), (p, t) => new {p, t});

            foreach (var q in ttt)
            {
                Console.WriteLine($"{q.p} - {q.p}");
            }
        }
        static void Linq50()
        {
            //LinqBegin50.Даны строковые последовательности A и B; все
            //    строки в каждой последовательности различны и имеют ненулевую длину. Получить последовательность строк вида 
            //    «E: N», где E обозначает один из элементов последовательности A, а N — количество элементов из B, начинающихся с того же символа, 
            //    что и элемент E(например, «abc:4»); количество N может быть равно 0.Порядок элементов полученной
            //последовательности должен определяться исходным порядком элементов последовательности A. 
            //    Указание.Использовать метод GroupJoin.

           List<string> a = new List<string>() {"jvd8",  "sd", "GGH" };
            List<string> b = new List<string>() { "r", "34", "gnffgnJJJ", "123" };

            var ttt = a.GroupJoin(b, e =>e, n => b.Count(j=>n.First() == e)

            foreach (var q in ttt)
            {
                Console.WriteLine($"{q.e} : {q.n}");
            }   
        } 
        static void Linqy6()
        {
            //LinqBegin46.Даны последовательности положительных целых чисел A и B; все числа в каждой последовательности различны.
            //Найти последовательность всех пар чисел, удовлетворяющих следующим условиям:
            //первый элемент пары принадлежит последовательности A, второй принадлежит B, и
            //оба элемента оканчиваются одной и той же цифрой.
            //Результирующая последовательность называется внутренним объединением последовательностей A и B по ключу, 
            //    определяемому последними цифрами исходных чисел.Представить найденное объединение в виде последовательности строк, 
            //    содержащих первый и второй элементы пары, разделенные дефисом, например, «49 - 129». Порядок следования пар должен определяться 
            //исходным порядком элементов последовательности A, а для равных первых элементов — порядком элементов последовательности B

            List<int> a = new List<int>() { 87, 4, 21, 79 };
            List<int> b = new List<int>() { 54, 18, 6, 67, 9 };

            var ttt = a.Join(b, p => p.ToString().Last(), t => t.ToString().Last(), (p, t) => new { p, t });

            foreach (var q in ttt)
            {
                Console.WriteLine($"{q.p} - {q.p}");
            }
        }






        public static void Test()
        {
            var book1 = new Book("C#",
                new List<TypeOfPage>
                {
                    TypeOfPage.Pictures, TypeOfPage.Tables, TypeOfPage.Text, TypeOfPage.Text, TypeOfPage.Text,
                    TypeOfPage.Pictures, TypeOfPage.Tables, TypeOfPage.Pictures
                });
            var book2 = new Book("Война и мир",
                new List<TypeOfPage>
                {
                    TypeOfPage.Pictures, TypeOfPage.Text, TypeOfPage.Text, TypeOfPage.Text
                });
            var book3 = new Book("Журнал моды №12",
                new List<TypeOfPage>
                {
                    TypeOfPage.Text, TypeOfPage.Pictures, TypeOfPage.Pictures, TypeOfPage.Pictures, TypeOfPage.Pictures, TypeOfPage.Pictures
                });
            var books = new List<Book> { book1, book2, book3 };
            //№2 получить общее количество страниц во всех книгах
            //Console.WriteLine(books.Sum(j=>j.Pages.Count));

            //№3 получить список всех страниц
            //var k = books.SelectMany(h => h.Pages).ToList();
            //foreach (var v in k)
            //{
            //    Console.WriteLine(v);
            //}

            //№4 получить имя книги с самым большим количеством страниц с картинками

            Console.WriteLine(books.OrderByDescending(d => d.Pages.Count(g => g == TypeOfPage.Pictures)).FirstOrDefault()?.Name ?? "ничего нет");

            ////№5 сформировать словарь, где ключ это название книги, а значение это список из страниц типа текст
            
            var dictionary =  books.ToDictionary(p => p.Name, b=> b.Pages.Where(j => j == TypeOfPage.Text));

            foreach (var tt in dictionary)
            {
                Console.WriteLine(tt.Key);
                foreach (var typeOfPage in tt.Value)
                {
                    Console.WriteLine(typeOfPage);
                }
            }
        }
    }
    public class Book
    {
        public string Name { get; set; }
        public List<TypeOfPage> Pages { get; set; }

        public Book(string name, List<TypeOfPage> pages)
        {
            Name = name;
            Pages = pages;
        }
    }

    public enum TypeOfPage
    {
        Pictures,
        Text,
        Tables
    }
}
  