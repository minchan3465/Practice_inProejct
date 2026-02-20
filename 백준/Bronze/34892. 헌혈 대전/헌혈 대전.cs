using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon_34892 {
	class Program {
		static void Main(string[] args) {
			//대학의 총 헌혈 참가자 = N
			//시립대 : X
			//경희대 : Y
			//외  대 : Z
			//즉, X + Y + Z = N

			//AX + BY + CZ = D
			//EX + FY + GZ = H

			//입력 : N A B C D E F G H... 개많아
			//출력 : X Y Z


			string[] input = Console.ReadLine().Split(' ');
			int N = int.Parse(input[0]);
			int A = int.Parse(input[1]);
			int B = int.Parse(input[2]);
			int C = int.Parse(input[3]);
			int D = int.Parse(input[4]);
			int E = int.Parse(input[5]);
			int F = int.Parse(input[6]);
			int G = int.Parse(input[7]);
			int H = int.Parse(input[8]);


			List<(int, int, int)> answer = new List<(int, int, int)>();

			for (int X = 0; X <= N; X++) {
				//Y 또는 Z는 N-X 의 숫자.
				for(int i = 0; i <= N-X; i++) {
					int Y = i;
					int Z = N - (Y+X);
					if (((A * X) + (B * Y) + (C * Z) == D)
				     && ((E * X) + (F * Y) + (G * Z) == H)) {
						(int, int, int) find = (X, Y, Z);
						answer.Add(find);
					}
				}
			}
			
			switch (answer.Count) {
				case 0:
					Console.WriteLine(2);
					break;
				case 1:
					Console.WriteLine(0);
					Console.Write(answer[0].Item1 + " ");
					Console.Write(answer[0].Item2 + " ");
					Console.Write(answer[0].Item3);
					break;
				default:
					Console.WriteLine(1);
					
					break;
			}
		}
	}
}
