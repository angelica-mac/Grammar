using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 접근지정자
public class Test
{
    private int a;  // 변수
    public int b;
    public static int c; // 공공의 공유자원

    public void Abc(){} // 함수에도 적용 가능
    private void Abc2(){}

    // 왜 나누느냐? public 실수로 접근해서 수정한다거나 제3자에게 노출되어서 분석당할 수 있음.
}
public class Part4B : MonoBehaviour
{
    Test aaa;

    Test a1;
    Test a2;
    Test a3;

    void start()
    {
        Abc();
    }

    void Abc()
    {
        aaa.b = 5;
       // aaa.a = 5; // private 접근 불가.
        aaa.Abc();
       // aaa.Abc2(); // private 접근 불가. 

        a2.b = 5;
        a1.b = 1;
        a3.b = 10;

        print(a1.b);
        print(a2.b);
        print(a3.b);
    }
}