using System;

class Program {
	static void Main(string[] args) {
		string[] input = Console.ReadLine().Split(' ');
		int N_length = int.Parse(input[0]);
		int K_length = int.Parse(input[1]);

		int min_lion = int.MaxValue;
		int max_lion = 0;
		int[] K_list = new int[K_length];
		for (int k = 0; k < K_length; k++) {
			int lion_num= int.Parse(Console.ReadLine());
			K_list[k] = lion_num;
			if (min_lion > lion_num) min_lion = lion_num;
			if (max_lion < lion_num) max_lion = lion_num;
		}

		int result = 0;
		for (int i = 0; i < K_length - 1; i++) {
			result += Math.Abs(K_list[i] - K_list[i + 1]);
		}

		int min_man = int.MaxValue;
		int max_man = 0;
		if(N_length > K_length) {
			for (int i = 0; i < (N_length - K_length); i++) {
				int num = int.Parse(Console.ReadLine());
				if (min_man > num) min_man = num;
				if (max_man < num) max_man = num;
			}
		}

		if (min_lion > min_man) result += GetMin(K_list, min_man);
		if (max_lion < max_man) result += GetMin(K_list, max_man);

		Console.WriteLine(result);
	}

	static int GetMin(int[] K_list, int num) {
		int min = Math.Abs(K_list[0] - num);
		min = Math.Min(min, Math.Abs(K_list[K_list.Length - 1] - num));
		for(int i =0; i < K_list.Length-1; i++) {
			int origin_val = Math.Abs(K_list[i] - K_list[i+1]);
			int insert_val = Math.Abs(K_list[i] - num) + Math.Abs(K_list[i+1] - num);
			int increase = Math.Min(min, Math.Abs(origin_val - insert_val));

			if (increase < min) min = increase;
		}
		return min;
	}
}
