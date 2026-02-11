using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
	static void Main(string[] args) {
		//2007년 2월 1일 : 역대 최대 규모의 콘서트를 염.
		//2007년 2월 11일 : 음악세계를 세상에 알림.
		//2007월 3월 4일 : 작곡 비법을 세계에 공개
		//2007년 3월 31일 : Heroes원정대 체스 부분 참가.
		//2007년 4월 21일 : 월드 노래자랑으로 우승
		//2008년 7월 13일 : 락동호 컴백
		//ㄴ 문제랑 연관도 없는데 서사 한번 ㅈㄴ 크네. 동호는 뭐하는 사람일까


		//FF : 빠르게 시작 - 빠르게 끝
		//FS : 빠르게 시작 - 느리게 끝
		//SF : 느리게 시작 - 빠르게 끝
		//SS : 느리게 시작 - 느리게 끝

		//퇴물된 동호는 조건에 맞춰서 곡 수록을 하려고 한다.
		//조건
		//- 1. 빠르게 시작하는 노래는 반드시 빠르게 끝나는 노래의 바로 다음에 와야한다.
		//- 2. 느리게 시작하는 노래는 반드시 느리게 끝나는 노래의 바로 다음에 와야한다.
		//	~> 즉, 노래 템포의 끝말잇기.
		//- 3. 빠르게 시작하는 노래가 한개라도 있다면, 빠른 곡이 제일 먼저.
		//동호는 이론상 음반에 곡 수록을 많이 해야한다.

		//입력 : 1 2 1 1 => FF FS SF SS 의 갯수
		//모든 수는 0 <= N <= 1000, 최소 하나는 0보다 큼.

		string[] input = Console.ReadLine().Split();

		int FF = int.Parse(input[0]);
		int FS = int.Parse(input[1]);
		int SF = int.Parse(input[2]);
		int SS = int.Parse(input[3]);

		//무조건 FF가 있으면, FF만 처음에 도배하고 계산하면 됨.
		//반대로, SS가 있으면 마지막에 SS 도배하면 됨.
		//그럼 역순으로 계산하면 된다!

		//FS와 SF는 둘이 한 쌍으로 있어야만 반복해서 사용할 수 있음.
		//

		int result = 0;
		if(FF > 0) {
			result = FF;	//빠른곡이 있으면 무조건 일단 추가해.
		}
		if(FS > 0) {
			result += SS;
			if (SF > 0) {
				result += (Math.Min(FS,SF) * 2);
				if (FS > SF) result += 1;
			} else {
				result += 1;
			}
		} else {
			if (!(FF > 0)) {
				result += SS;
				if (SF > 0) result += 1;
			}
		}
		Console.WriteLine(result);
	}
}
