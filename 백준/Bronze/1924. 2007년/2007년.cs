using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon_1924 {
	class Program {
		static void Main(string[] args) {
			//방법 두가지가 있다.
			//1. 로직으로 구현해서 만들기
			//2. DayOfWeek 메서드 사용하기.


			//그래도 논리적 향상인데, 1번을 쓰는게 맞지 않을까?


			string[] input = Console.ReadLine().Split(' ');
			int x = int.Parse(input[0]);
			int y = int.Parse(input[1]);
			string[] day = { "SUN","MON", "TUE", "WED", "THU", "FRI", "SAT"};

			int day_count = 0;
			for(int i = 1; i < x; i++) {
				switch (i) {
					case 1:
					case 3:
					case 5:
					case 7:
					case 8:
					case 10:
					case 12:
						//31일 
						day_count += 31;
						break;
					case 4:
					case 6:
					case 9:
					case 11:
						//30일
						day_count += 30;
						break;
					case 2:
						//28일
						day_count += 28;
						break;
				}
			}
			day_count += y;
			int day_index = day_count % 7;
			Console.WriteLine(day[day_index]);
		}
	}
}
