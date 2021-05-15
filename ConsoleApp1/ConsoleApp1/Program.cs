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
		static class Tools
		{
			public static void READ_LINE() => Console.ReadLine();
			public static void CWL(string txt) => Console.WriteLine(txt);
			public static void CW(string txt) => Console.Write(txt);
			public static void ERROR(string txt)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				CWL(txt);
				Console.ForegroundColor = ConsoleColor.White;
			}
			public static void ShowBuffer(List<int> buffer)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				foreach (var item in buffer) CW($"{item} ");
				Console.ForegroundColor = ConsoleColor.White;
			}
		}

		static class MyRandom
		{
			static Random rnd = new Random(Environment.TickCount);

			public static List<int> GetList(int size)
			{
				var tmp = new List<int>();

				for (int i = 0; i < size; i++) tmp.Add(rnd.Next(1, 10));

				return tmp;
			}
		}

		static void LoadSettings()
		{
			Tools.CWL("> Hello my friend!");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Title = "15.05.2021 | 263";
		}

		static void Main()
		{
			LoadSettings();

			bool check_status = false;
			while (!check_status)
			{
				try
				{
					Tools.CW("Введите размер массива: ");

					List<int> buffer = MyRandom.GetList(
						int.Parse(Console.ReadLine())
					);

					buffer.Sort();

					Tools.ShowBuffer(buffer);


					Tools.CW("\nВведите чо нада: ");
					int p = Convert.ToInt32(Console.ReadLine());

					int tmp1 = buffer.Find(x => x == p);
					if (tmp1 == 0)
					{
						Tools.CWL("Элемента нема");
					}
					else
					{
						Tools.CWL($"Найдено: {tmp1}");
						Tools.CWL($"Индекс: {buffer.FindIndex(x => x == tmp1)}");
					}

					check_status = true;
				}
				catch (Exception er) { Tools.ERROR(er.Message); }

				Tools.READ_LINE();
			}
		}
	}
}
