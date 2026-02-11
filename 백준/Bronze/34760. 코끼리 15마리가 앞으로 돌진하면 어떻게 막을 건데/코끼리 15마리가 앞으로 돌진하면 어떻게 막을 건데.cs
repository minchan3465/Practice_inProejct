using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
	static void Main(string[] args) {
		//건국대에 코끼리 15마리. i번째 코끼리 코는 Ai다. (인공지능 말하는거 아님)

		//1번부터 15번까지 돌진하고, 당근 한개로 길을 막으려고한다.

		//코끼리는 당근보고
		//- 당근 길이 < 코의 길이 = 당근 먹고 돌진
		//- 당근 길이 = 코의 길이 = 당근 먹고 잠. (멈춤)
		//- 당근 길이 > 코의 길이 = 당근 보고 놀라 기절 (멈춤)
		//- 만약 당근이 없다면 계속 돌진

		//멈춘 코끼리는 다른 코끼리에 영향을 주지 않는다.

		//모든 코끼리의 돌진을 멈추기 위해, 필요한 당근의 최소 길이.

		//즉, 가장 코의 길이가 긴 코끼리의 코 길이의 당근을 정확히 맞추면 되는거 아닌가?
		//+ 마지막 코끼리가 제일 코가 크면, 해당 코끼리에 코 길이에 맞춰서 종료.
		//+ 마지막이 아니면, 코끼리의 코의 길이보다 +1 만큼 해줘야함. (아니면 당근이 사라져서 코끼리를 못멈춤!)

		string[] input = Console.ReadLine().Split(' ');

		int max_size = 0;
		int high_index = -1;
		for(int i = 0; i < input.Length; i++) {
			if (max_size < int.Parse(input[i])) {
				max_size = int.Parse(input[i]);
				high_index = i;
			}
		}
		if (high_index != input.Length-1) max_size += 1;
		Console.WriteLine(max_size);
	}
}
