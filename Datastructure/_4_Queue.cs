using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _4_Queue
    {
        public _4_Queue()
        {
            /*
            * System.Collections.Generic
            */

            // 생성
            Queue<int> queue = new Queue<int>();

            // 삽입
            // Enqueue(data) : data를 큐 맨 뒤에 삽입
            queue.Enqueue(10); // [10]
            queue.Enqueue(30); // [10,30]
            queue.Enqueue(20); // [10,30,20]

            // 제거
            // Dequeue() : 큐에서 맨 앞 원소를 제거 후 반환
            int data = queue.Dequeue(); // data:10, [30,20]
        }
    }
}
