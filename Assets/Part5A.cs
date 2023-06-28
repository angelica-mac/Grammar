using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part5A : MonoBehaviour
{   
    // 기본연산자 + - * / %(나머지) = (대입연산자)
    // 증감연산자 ++ --  전위(선 연산, 코드실행) 후위(선 코드실행, 후 연산)
    // 관계연산자 == != <= >= < > 
    // 논리연산자 &&(And) 모든 조건이 참일 때만 True ||(or) 조건 중에 하나라도 참이면 True ! 결과값 반대로 
    // 비트연산자(2진법)    &(AND)      |(OR)       ^(XOR)     ~(NOT)         
    //                 001010       001010      001010     001001
    //                 001100       001100      001100     110110
    //                 001000       001110      001001    결과를 뒤집음.
    //              둘다 1일때만 1             같으면 1 다르면 0 
    //                        1이 하나라도 있으면 1
    // 비트 이동 >>(나누기) <<(곱하기) 정도로 생각하면 될듯. 정확히는 아니지만 (10진법)
    // 00000001 = 1 (<<3) 
    // 00001000 = 8 (>>2)
    // 00000010 = 2 (<<1)
    // 00000100 = 4 

    int a = 10;
    int b = 10;
    int c = 0;
    bool d = false;

    // Start is called before the first frame update
    void Start()
    {
        print(a%b); // 나머지 0
        a += b; // a = a + b // 복합대입연산자 대입연산자(=)앞에 기본연산자 입력.
        print(a); // 20
     
        c = c + 1;
        c += 1; c++; ++c; // 무조건 1을 더해주고 싶을 때 사용.

        print(++c); // 1  전위(+1 먼저 해주고 c 실행) 
        print(c++); // 0  후위(c 실행 후) 
        print(c);   // 1     (+1)

        d = (a == b);  // 관계연산자
        print(d);  // True

        d = (a == b) && (a != b); // AND
            // True     // False 
        print(d); // False

        d = (a == b) || (a != b); // OR
            // True     // False
        print(d); // True

        d = !(a==b); // ! Not
        print(d); // False

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
