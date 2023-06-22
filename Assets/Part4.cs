using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part4 : MonoBehaviour
{
    int a = 5; // 멤버 변수, 전역 변수

    void Abc()
    {
        a = 6;

        int b = 5; // 지역 변수
        print(b);
    }

    void Abc2()
    {
        int b = 5; // 지역 변수
        print(b);
    }
    
}
