using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part4A : MonoBehaviour
{   //범위지정자
    int a = 5; // 멤버변수, 전역변수

    void Abc()
    {
        // int a = 5; // 지역변수 // 6으로 바뀜. // 평상시에는 존재하지 않다가 이 함수가 실행되고 나서야 이 변수도 생성됨.
                    // 함수가 끝나면 이 변수도 같이 소멸됨. // 생성과 파괴가 자주 이루어짐.

        a = 6; // 지역변수로 지정됨. 이름이 똑같으면 멤버변수 무시됨.

        int b = 5; // 지역변수
        print(b);
    }

    void Abc2()
    {
        int b = 5; // 지역이 다르면 이름이 같아도 상관없음. 서로 간섭하지 않음.
        print(b); //할당되지 않았다면 오류 생김.
    }

    void Abc3(float _parameter) // 매개변수
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
