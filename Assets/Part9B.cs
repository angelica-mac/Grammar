using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9B : MonoBehaviour
{
    // 컬렉션 : 리스트, 큐, 스택, 해시테이블, 딕셔너리, 어레이리스트

    ArrayList arrayList = new ArrayList(); // 매번 특정 연산을 필요. 상대적으로 List보다 연산량이 많고 과부화 걸림.

    List<int> list = new List<int>(); // 특정 자료형만 입력 가능. arrayList와 유일한 차이점.

    Hashtable hashtable = new Hashtable();

    Dictionary<string,int> dictionary = new Dictionary<string, int>(); // arrayList와 List의 차이처럼 연산에서 Hashtable보다 유리함.

    Queue<int> queue = new Queue<int>(); // 선입선출 FIFO First In First Out //자료형 명시해도 되고 안해도 됨. // 넣고 뺄 수만 있음.
                                        // cf) 게임 : 포션 제작 대기줄, 실생활 : 은행 대기줄

    Stack<int> stack = new Stack<int>(); // 후입선출 LIFO //자료형 명시해도 되고 안해도 됨.
                                        // cf) 요리게임 : 설거지한 접시가 쌓이면 쌓인 순서대로 요리가 나가겠지.

    // Start is called before the first frame update
    void Start()
    {
        list.Add(1);
    //  list.Add("가나다"); // 오류. int 정수형을 입력해줬기 때문. 
        
        hashtable.Add("만",10000);
        hashtable.Add("백만",1000000);
        hashtable.Add(50,"오십");

        print(hashtable[0]); // Null : 값이 없다는 뜻.
        print(hashtable["만"]); // 인덱스로 접근할게 아니라 키값으로 접근.
        print(hashtable["백만"]);
        print(hashtable[50]);
        // 나머지는 비슷함. remove clear 등 동일.

        dictionary.Add("가",100);

        queue.Enqueue(5);
        queue.Enqueue(10);

        if(queue.Count !=0) // 갯수가 있는지 없는지 체크하고 사용해줘야 함.
            print(queue.Dequeue());
        if(queue.Count !=0)
           print(queue.Dequeue());
        if(queue.Count !=0)     // 조건문 달아주면 오류 안남. !=0 0개가 아니라면
        print(queue.Dequeue()); // queue enpry 오류.

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        print(stack.Pop());
        print(stack.Pop());
        print(stack.Pop());
        if(stack.Count !=0)
        print(stack.Pop());



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
