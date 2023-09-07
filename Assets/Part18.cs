using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 람다식()>=
public class Part18 : MonoBehaviour
{
    int a = 5;
    int b = 5;

    int sum;

    void Add()
    {
        sum = a + b;
    // Back()  //Add 함수가 호출되면 Back도 같이 호출되게 하고 싶을때. Add함수 안에 Back 매서드를 호출시키면 됨.
               //Back()은 Add()에 종속됨. Add()만 호출시킬 수 없음. - 델리게이트로 해결.
    }

    void Back()
    {
        sum = 0;
    }

    // 델리게이트 - 여러개 함수 동시에 호출 시킬 수 있음.
    delegate void Mydelegate();
    Mydelegate mydelegate;

    // Start is called before the first frame update
    void Start()
    {
        mydelegate = Add;
        
        // 무명 메소드 : 함수를 만들지 않아도 델리게이트에 넣을 수 있다. 다른함수들 처럼 이름이 없음 대신 delegate키워드 사용. 
        //            delegate를 통해서만 호출 가능
        mydelegate += delegate () { print(sum);};

        mydelegate += Back;

        mydelegate(); // 이렇게 하면 둘다 호출 되는 거지.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
