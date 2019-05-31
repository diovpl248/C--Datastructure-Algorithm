using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _1_Array
    {
        public _1_Array()
        {
            /*
            NET Framework의 System.Array에서 파생된 것으로
            상속에 의해 System.Array의 메소드, 프로퍼티를 사용할 수 있다.
            */

            // 배열 선언
            int[] scores = new int[5];
            int[] scores2 = new int[5]{30,10,50,40,20};// 선언과 동시에 초기화

            // 2차원 배열
            int[,] scores3 = new int[2, 3];
            int[,] scores4 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            var length = scores.Length; // 배열의 크기
        }
    }
}
