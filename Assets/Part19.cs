using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Action 과 Func
// 델리게이트 자체를 줄인거라 생각하면 됨.
// Action 과 Func의 차이 반환타입이 있느냐 없느냐(없으면 Action, 있으면 Func)
public class Part19 : MonoBehaviour
{
    delegate void MyDelegate< T1, T2>(T1 a, T2 b);
    delegate string MyDelegate2< T1, T2>(T1 a, T2 b);

    MyDelegate<int,int> myDelegate;
    
    // Action,Func 자동완성 없음. using System 추가해줘야함.
    Action<int, int> myDelegate2; // system에 똑같은 부호가 만들어져 있음. System에 미리 정의되어 있는 것을 가져다 쓰기만 하면 됨.
    Func<int, int, string> myDelegate3;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate3 = ( int a, int b ) => { int sum = a+b; return sum + "이 리턴되었습니다."; };
        print(myDelegate3(3,5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
