using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void CWL(string txt) => Console.WriteLine(txt);
		static void CW(string txt) => Console.Write(txt);
		static Random rnd = new Random(Environment.TickCount);

		public static List<int> GetList(int size)
		{
			var tmp = new List<int>();

			for (int i = 0; i < size; i++) tmp.Add(rnd.Next(0, 10));

			return tmp;
		}


		static void Main(string[] args)
		{
			while (true)
			{
				try
				{
					CW("Введите размер массива: ");

					int size = int.Parse(Console.ReadLine());
					List<int> buffer = GetList(size);
					//buffer.Sort();
					buffer.GroupBy(x => buffer);
					CWL("press f");
				}
				catch (Exception er)
				{
					CWL(er.ToString());
				}

				Console.ReadLine();
			}
			
		}
	}
}
