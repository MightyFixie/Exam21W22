using System;

namespace T13 {
	class Program {
		delegate double MyDel(int a, int b, int c);

		static void Main() {
			MyDel avg = (a, b, c) => {
				return ((double)a + b + c) / 3;
			};

			Random rng = new Random();
			int d = rng.Next();
			int e = rng.Next();
			int f = rng.Next();
			Console.WriteLine(d);
			Console.WriteLine(e);
			Console.WriteLine(f);
			Console.WriteLine(avg(d, e, f));

			Console.ReadKey(true);
		}
	}
}
