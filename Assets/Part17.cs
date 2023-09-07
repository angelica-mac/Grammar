using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 17 형식 매개변수 T (Type의 약자)

// 이번에는 클래스에다 형식 매개변수를 이용해보자.
public class ABC<T>
{
    public T var;
    public T[] array;
}

public class Part17 : MonoBehaviour
{
    void Print(int value)
    { print(value);}

    void Print(string value)
    { print(value);}

    void Print(float value)
    { print(value);}

    // 3개만 해도 많지? 이럴 때 등장하는게 형식 매개변수
    void Print2<T>(T value)  // 불특정 타입의 매개변수를 받을 때 / 형식 매개 변수 T 사용.
//  void Print2<T>(T value)  where T : class , struct  // 올 수 있는 타입을 명시시켜줄 수 있음. 그 외에 다른 것들은 오류 뜨게 만들 수 있음.
                                    // strint - class, float - struct
    { print(value); }


    ABC<string> a;
    ABC<float> b;

    // Start is called before the first frame update
    void Start()
    {
        // 이름이 같은 함수는 매개변수로 구분
        print("abc"); // 문자. string 매개변수 2번째 함수 선택됨.
        print(4.5f); // 실수. float 매개변수 3번째 함수 선택됨.

        Print2<string>("abc"); // string이 T로 가서 T가 string이 됨. T value 도 string value가 됨.
        Print2<float>(4.5f);

        a.var = "abc";
        b.var = 4.5f;
        a.array = new string[1];
        b.array = new float[2];

        a.array[0] = "abc";
        b.array[0] = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
