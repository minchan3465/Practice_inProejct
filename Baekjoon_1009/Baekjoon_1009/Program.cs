using System;
using System.Collections.Generic;

class Program {
	static void Main(string[] args) {
		int cnt;
		List<int> list = new List<int>();
		cnt = int.Parse(Console.ReadLine());

		for (int i = 0; i < cnt; i++) {
			list.Clear();

			string input = Console.ReadLine();
			string[] _split = input.Split(' ');

			int a = int.Parse(_split[0]);
			int b = int.Parse(_split[1]);

			int _a = a % 10;

			list.Add(_a);
			int j = 1;
			while (true) {
				j += 1;
				int result = (int)(Math.Pow(a, j) % 10);
				if (_a == result) break;
				list.Add(result);
			}

			int n = b % list.Count;
			if (n == 0) n = list.Count;
			int last = list[n - 1];
			if(last == 0) {
				Console.WriteLine(10);
			} else {
				Console.WriteLine(list[n - 1]);
			}
		}
	}
}