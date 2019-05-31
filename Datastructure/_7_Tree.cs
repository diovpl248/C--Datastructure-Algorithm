using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _7_Tree
    {
        public _7_Tree()
        {
            // .NET Framework는 기본적으로 Tree에 관한 클래스를 제공하지 않는다.
            // 직접 구현해서 사용하는것은 http://www.csharpstudy.com/DS/tree.aspx 사이트를 참고

            // SortedDictionary클래스는 내부적으로 이진검색트리를 사용하여 Key를 찾고 Value를 찾는다.
            // 중복된 키를 허용하지 않고, 추가, 삭제, 검색에 O(log n)의 시간이 소요된다.

            /*
             * System.Collections.Generic
             */

            // 생성
            SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();

            // 삽입
            tmap.Add(10, "Kim");
            tmap.Add(20, "Lee");
            tmap.Add(30, "Park");

            // 제거
            tmap.Remove(20); // 지정한 키를 가지는 요소 제거

            // 읽기
            if(tmap.ContainsKey(10))
            {
                var value = tmap[10];
            }
        }
    }
}
