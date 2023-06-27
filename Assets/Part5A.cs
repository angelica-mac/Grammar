using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part5A : MonoBehaviour
{// 연산자
// 기본연산자 + - * / %(나머지 값) =(대입연산자)

int a = 10;
int b = 3;
int c = 0;

void start()
{
    a += b; // a = a + b 복합대입연산자
    c = c+1; // c += 1, c++ ++c 1만 더해주고 싶을때 사용

    print(a); // 13
    print(++c); //1을 먼저 더한값을 출력
    print(c++); //0을 출력후 다음부터 1을 더함.
}
}
