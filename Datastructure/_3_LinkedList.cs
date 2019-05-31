using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _3_LinkedList
    {
        public _3_LinkedList()
        {
            /*
             * System.Collections.Generic
             */

            // 생성 및 초기화
            LinkedList<int> linkedList = new LinkedList<int>();

            // 원소 추가
            linkedList.AddFirst(10); // [10]
            linkedList.AddFirst(20); // 앞쪽에 추가됨 : [20,10]
            linkedList.AddLast(30); // 뒤쪽에 추가됨 : [20,10,30]
            linkedList.AddBefore(linkedList.Last, 50); // 지정된 노드 앞에 추가됨 : [20,10,50,30]
            linkedList.AddAfter(linkedList.Last, 10); // 지정된 노드 뒤에 추가됨 : [20,10,50,30,10]

            // 원소 제거
            linkedList.Remove(10); // 일치하는 첫번째 노드 제거 : [20,50,30,10]
            linkedList.RemoveFirst(); // 맨 앞 노드 제거 : [50,30,10]
            linkedList.RemoveLast(); // 맨 뒤 노드 제거 : [50,30]
        }
    }
}
