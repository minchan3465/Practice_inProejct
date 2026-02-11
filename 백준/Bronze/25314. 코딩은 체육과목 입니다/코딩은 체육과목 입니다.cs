using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon_25314 {
	class Program {
		static void Main(string[] args) {
			//혜아는 long이 붙을때마다 4bytes씩 늘어나는줄 안다. 멍청한년.

			int N = int.Parse(Console.ReadLine());

			for(int i = 0; i < (N/4); i++) {
				Console.Write("long ");
			}
			Console.WriteLine("int");
		}
	}
}
