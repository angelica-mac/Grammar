using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test
{
    private int a; // 접근 차단.
    public int b; // 보안 떨어짐. 나도 모르게 실수로 접근 수정된다거나,제3자에게 노출되어 분석당할지도. 
    public static int c; // 공공의 공유자원. 정적변수
    public void Abc() // 함수에도 적용 가능.
    {

    }
    private void Abc2()
    {

    }
}
public class Part4B : MonoBehaviour
{   //접근지정자
    Test aaa;
    void Abc()
    {
        aaa.b = 5; // 다른 class의 b를 만질 수 있음.
     // aaa.a = 5; // 보호수준이 private이라서 접근 불가.
        aaa.Abc();
     // aaa.Abc2(); // 보호수준 때문에 접근할 수 없음.
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
