using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14A : MonoBehaviour
{
    private int salary;

    public int SalaryP { get { return salary; }  set { salary = value; } }
    //타클래스 접근 가능    // 읽기                  // 쓰기        //반드시 value로 해줘야 함. 다른걸로 하면 오류남. 
                                                             //우리가 선언하지 않았지? 이건 미리 예약어와 같이 누군가 만들어놓은 변수. 


    // Start is called before the first frame update
    void Start()
    {
        SalaryP = 10; // 이 값이 value로 들어가고 private int salary 로 들어감.

        print(SalaryP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
