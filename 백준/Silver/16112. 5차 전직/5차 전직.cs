using System;


class Program {
	static void Main(string[] args) {
		// n개의 퀘스트
		// i번째 퀘스트를 진행하면 Ai의 경험치와 i번째 아케인 스톤.
		// i번째 보상 경험치를 받을때, 아케인스톤에는 Ai 경험치가 추가됨.

		// 해킹해서 최대 경험치 제한을 없에버리고 (원랜 5억)
		// 최대 k개의 아케인스톤을 활성화 할 수 있다.

		//첫째줄에 정수 n과 k (1<= k <= n <=  3 * 10 5승= 300,000)
		//둘째줄에 n개의 정수가 공백을 사이에 두고 주어집니다. i번째 정수는 ai이며, 0보다 크고 10^8 = (1,000,000 백만)보다 작거나 같다.


		//n = 퀘스트 수 / k = 활성 아케인 수
		//그냥 작은 수부터 퀘스트 클리어한다음 활성화 하고 깨는게 제일 비싼거 아닌가?

		//가장 작은 수부터 클리어하며 경험치 손실을 줄이고, 활성화 시킨 다음 차례차례 올린다.
		//활성화된 아케인스톤 k에 그만큼 다 들어가니, 총 경험치는 k배 오르는거고.

		//아니 왜 틀렸다고 하는건지 모르겠네.

		string[] input_one = Console.ReadLine().Split(' ');
		int n = int.Parse(input_one[0]);
		int k = int.Parse(input_one[1]);

		string[] input_two = Console.ReadLine().Split(' ');
		long[] exp_list = new long[n];
		for (int i = 0; i < input_two.Length; i++) {
			exp_list[i] = long.Parse(input_two[i]);
		}
		Array.Sort(exp_list);	//오름차순 정렬

		long result = 0;
		int active_k = 0;
		for(int i = 0; i< exp_list.Length; i++) {
			result += exp_list[i] * active_k;
			if (active_k < k) { active_k++; }
		}

		Console.WriteLine(result);
	}
}
