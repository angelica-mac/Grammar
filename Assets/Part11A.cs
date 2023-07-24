using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// class와 동일한 방법으로 쓰이는게 struct
// 호환성 문제로 구버전 struct를 그대로 두었다고 생각하면 됨.
// 신버전 class는 상속(MonoBehaviour) 가능. 구버전 struct는 상속 불가능.
// struct 장점 : 선언과 동시에 내부적으로 = new int a(); 작동하므로 입력해줄 필요 없음.
// struct 값 타입 class 주소 타입.


public struct Youtube 

{
    public int a;   // 오류. 구제체에는 값을 입력할 수 없음. 단순하게 그릇 역할만 하겠다는 것. 
                   // 값을 넣어줄려면 public을 입력해주거나

    public void GetA(int value)   // a에 파라미터를 받아서 값 입력 가능. 
    {
        a = value;
    }
}

public class Part11A : MonoBehaviour
{

    Youtube Angleica;

    // Start is called before the first frame update
    void Start()
    {
        Angleica.a = 5;  //  값을 직접 넣을 수도 있고
        Angleica.GetA(5); // 함수를 이용해서 값을 넣을 수도 있음.
        print(Angleica.a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
