using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure
{
    class _5_Stack
    {
        public _5_Stack()
        {
            /*
             * System.Collections.Generic;
             */

            // 생성
            Stack<int> stack = new Stack<int>();

            // 삽입
            // Push(data) : data를 맨 뒤에 삽입합니다.
            stack.Push(10); // [10]
            stack.Push(30); // [10,30]
            stack.Push(20); // [10,30,20]

            // 삭제
            // Pop(): 맨 뒤의 원소를 삭제 후 반환
            var data = stack.Pop(); // data:20, [10,30] 
        }
    }
}
