using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14C : MonoBehaviour
{
    private int salary;

    private void GetSalary(int value)
    {
        salary = value;
    }

    public int GetSalary()
    {
        return salary;
    }

    // 지금은 1개이지만 민감한 정보가 여러가지이다. 그러면 함수가 복잡해지겠지? 그럴때 필요한게 프로퍼티 - Part14A 로 연결.

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
