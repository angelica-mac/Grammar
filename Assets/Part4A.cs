using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//범위지정자
public class Part4A : MonoBehaviour
{
    int a = 5; // 멤버 변수, 전역 변수

    void Abc()
    {
      //  int a = 5; // 지역 변수 //이게 6이 됨.

        a = 6; // 지역변수로 지정됨. 멤버변수(우위) > 지역변수 // 멤버변수와 지역변수가 이름이 같을경우 멤버변수 무시됨.

        int b = 5; // 지역 변수
        print(b);
    }

    void Abc2()
    {
        int b = 5; // 지역 변수; 같은 지역만 아니라면 이름이 같은 변수 선언 가능.
        print(b);
    }

    void Abc3(float _parameter) // 매개변수
    {

    }
}
