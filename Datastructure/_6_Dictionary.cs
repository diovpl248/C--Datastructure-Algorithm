using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _6_Dictionary
    {
        public _6_Dictionary()
        {
            // Dictionary는 내부적으로 Hashtable로 구현돼있고 Chaining 방식을 사용해서 충돌처리를 한다.
            // 삽입, 삭제, 검색에서 O(1)이 소요된다.

            /*
             * System.Collections.Generic;
             */

            // 생성 (Key, Value)
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // 삽입
            dictionary.Add(10, "Kim");
            dictionary.Add(20, "Lee");
            dictionary.Add(30, "Park");

            // 삭제
            dictionary.Remove(20); // 키값 제거

            // 참조
            if (dictionary.ContainsKey(10))
            {
                var value = dictionary[10];
            }
        }
    }
}
