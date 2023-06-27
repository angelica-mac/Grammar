using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2
{
    private int a; 
    public int b; 
    public static int c;
}
public class Part4C : MonoBehaviour
{
    Test2 a1 = new Test2(); // 배열타입을 변수로 삼을때는 선언만 하면 오류 뜸. 할당해줘야 함.
    Test2 a2 = new Test2();
    Test2 a3 = new Test2();

    void Start()
    {
        Abc();
    }

    void Abc()
    {
        a2.b = 5;
        a1.b = 1;
        a3.b = 10;

        Test2.c = 100; // class 자체로 접근. 공유자원을 수정하려면 class 자체로 접근해야 함.

        print(a1.b);
        print(a2.b);
        print(a3.b);
        print(Test2.c);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
