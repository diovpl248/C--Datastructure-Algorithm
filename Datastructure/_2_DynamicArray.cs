using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _2_DynamicArray
    {
        public _2_DynamicArray()
        {
            /*
             * System.Collections.Generic
             * ArrayList를 사용할경우 박싱 / 언박싱이 일어나고, 배열의 요소를 읽을때
             * 캐스팅해줘야하는데, List<T>는 그런 문제가 없다.
             */

            // 선언 및 초기화
            List<int> list = new List<int>();
            List<int> list2 = new List<int>() { 10,30,20};

            // 원소 추가
            list.Add(10); // [10]
            list.Add(30); // [10,30]
            list.Add(20); // [10,30,20]

            // 원소 제거
            list.Remove(30); // 일치하는 첫번째 원소 제거
            list.RemoveAt(0); // index에 해당하는 원소 제거
        }
    }
}
