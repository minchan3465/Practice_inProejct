using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
	static void Main(string[] args) {
		int T = int.Parse(Console.ReadLine());
		for(int i = 0; i < T; i++) {
			int N = int.Parse(Console.ReadLine());

			List<int> fibonacci = new List<int>();
			for(int j = 0; j < N; j++) {
				if (j == 0) fibonacci.Add(1);
				else if (j == 1) fibonacci.Add(1);
				else fibonacci.Add(fibonacci[j - 1] + fibonacci[j - 2]);
			}

			int zero = 0;
			int one = 0;

			if (N == 0) zero = 1;
			else if (N == 1) one = 1;
			else {
				zero = fibonacci[N - 2];
				one = fibonacci[N - 1];
			}

			Console.WriteLine($"{zero} {one}");
		}
	}
}
