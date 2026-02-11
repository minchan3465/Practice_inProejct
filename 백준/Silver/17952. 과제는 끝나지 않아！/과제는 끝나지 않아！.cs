using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon_17952 {
	class Program {
		static void Main(string[] args) {
			//성에는 전공을 많이 들어서 과제를 매일 한다고 한다. 난가?
			//1. 과제는 가장 최근에 나온 순서대로, 또한 과제를 받으면 바로 시작 ~> Stack 개념?
			//2. 과제를 하던 도중 새로운 과제가 나온다면, 하던 과제를 중단하고 새로운 과제를 진행한다 ~> 이거 그건데 그 프로세스 선점? 비선점? 아 뭐더라... 맞네 선점or비선점 이건 비선점이다.
			//3. 새로운 과제가 끝났다면, 이전에 하던 과제를 이전에 하던 부분부터 이어서 한다. (성애는 기억력이 좋아 하던 부분을 기억한다고 한다.)

			//이건 비선점 프로세스 FILO (First In Last Out) 이다.
			//먼저 들어온 애가 제일 마지막에 처리될 수 밖에 없는 구조.


			//예제로 하는것.
			//이번 학기는 3분 (N=3, 1<=N<=1,000,000)

			//두번째 줄 부터
			//N줄 동안은 학기가 시작하고, N분째에 주어진 과제의 정보가 아래의 두 경우 중 하나로 주어진다.
			//- 1 A T = 과제의 만점은 A점이고, 이 과제를 해결하는데 T분이 걸린다.
			//- 0 : 이 시점에는 과제가 주어지지 않았다.

			int N = int.Parse(Console.ReadLine());

			Stack<int> time_stack = new Stack<int>();
			Stack<int> score_stack = new Stack<int>();

			int result = 0;
			for (int i =0; i < N; i++) {
				string[] input = Console.ReadLine().Split(' ');

				if(input[0].Equals("1")) {
					score_stack.Push(int.Parse(input[1]));
					time_stack.Push(int.Parse(input[2]));
				}

				if(time_stack.Count != 0) {
					int assign_remain_time = time_stack.Pop();
					assign_remain_time -= 1;
					if (assign_remain_time == 0) {
						result += score_stack.Pop();
					} else {
						time_stack.Push(assign_remain_time);
					}
				}
			}

			Console.WriteLine(result);

		}
	}
}
