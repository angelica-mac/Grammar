using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14C : MonoBehaviour
{
    private int salary;  // 봉급 매우 중요한 정보. 함부로 읽고 쓸 수 없게. 쓰기는 이 클래스 안에서만 가능하게 만들거임. // 은닉성 보장
    // 지금은 1개이지만 민감한 정보가 여러가지라면 함수가 복잡해지겠지? 그럴때 필요한게 프로퍼티 - Part14A 로 연결.

    private void GetSalary(int value)  // 쓰기 
    {
        salary = value;
    }

    public int GetSalary()  // 읽기. 타 클래스에서 값을 수정할 수는 없지만 읽어들일 수는 있겠지.
    {
        return salary;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
