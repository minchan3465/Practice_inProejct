using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon_34979 {
	class Program {
		static void Main(string[] args) {
			//대신고 본관은 4층. N개의 반
			//왼쪽부터 오른쪽으로 1~N번
			//1~4층은 아래에서 위로.

			//한 반에서 공사하면, 해당 반과 상하좌우의 반에 영향 (존재X반은 무시)
			//처음에는 불쾌감이 0이며, Q개의 쿼리가 주어진다.

			//1 a b : a층 b반에서 공사가 발생한다. 이때 영향을 받는 모든 반의 불쾌함을 1만큼 증가시킨다.
			//2 a : a층에서 가장 불쾌함이 높은 반의 번호를 출력한다. a층에서 불쾌함이 가장 높은 반이 둘 이상일 경우, 반 번호가 더 작은반을 출력

			//모든 쿼리를 수행한 후, 건물 전체에서 불쾌함이 가장 높은 반을 이달의 오량반으로 선정한다. 이때도 여러개가 나올 경우, 층수가 더 낮은 층을 우선. 층수가 같다면 반 번호가 더 작은 반을 선택.

			//입력 : 첫번째 줄 -> N Q
			//		 두번째 줄 이상 -> q번에 걸쳐, 같은 쿼리가 주어진다.	(1 a b , 2 a b) 1과 2로 구분.
			//출력 : 2번 쿼리에 대해서 정답을 한줄에 하나씩 순서대로 출력한다.
			//	     마지막 줄에는 이달의 오량반의 층수와 반 번호를 출력.


			string[] input = Console.ReadLine().Split(' ');
			int N = int.Parse(input[0]);
			int Q = int.Parse(input[1]);

			int[,] school = new int[4, N+1]; //4층 N반

			for (int i = 0; i < Q; i++) {
				string[] Query = Console.ReadLine().Split(' ');
				int Query_num = int.Parse(Query[0]);
				int Floor = 4 - int.Parse(Query[1]);
				if (Query_num == 1) {
					int Class = int.Parse(Query[2]) - 1;
					//불쾌함 주기
					school[Floor, Class] += 1;
					if (Floor != 0) school[Floor - 1, Class] += 1;  //상
					if (Floor != 3) school[Floor + 1, Class] += 1;  //하
					if (Class != 0) school[Floor, Class - 1] += 1;  //좌
					if (Class != N - 1) school[Floor, Class + 1] += 1;  //우
				} else {
					int Max_pain = -1;
					int Higher_Pain_Class = 0;
					for (int j = N; j >= 0; j--) {
						int class_pain = school[Floor, j];
						if (class_pain >= Max_pain) {
							Max_pain = class_pain;
							Higher_Pain_Class = j;
						}
					}
					Console.WriteLine(Higher_Pain_Class + 1);
				}
			}

			//for(int i = 0; i< 4; i++) {
			//	for(int j=0; j <= N; j++) {
			//		Console.Write($"{school[i,j]} ");
			//	}
			//	Console.WriteLine();
			//}

			int Painest_Floor = -1;
			int Painest_Class = -1;
			int Pain_Value = 0;
			for (int i = 0; i < 4; i++) {
				for (int j = N; j >= 0; j--) {
					int class_pain = school[i, j];
					if (class_pain >= Pain_Value) {
						Pain_Value = class_pain;
						Painest_Floor = i;
						Painest_Class = j;
						continue;
					}
				}
			}
			Console.WriteLine($"{4 - Painest_Floor} {Painest_Class + 1}");
		}
	}
}