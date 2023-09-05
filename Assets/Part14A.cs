using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14A : MonoBehaviour
{
    // 프로퍼티 장점1 은닉성 보장 , 장점2 논리성 오류 보장, 장점3 자동완성 프로퍼티 (프로퍼티 자체가 변수의 역할도 함.)

    private int salary;

    private int bonus = 10;

    public int Bonus { get; set; }

    public int SalaryP { get { return salary; }  private set { salary = value; } }
    //타클래스 접근 가능    // 읽기                  // 쓰기        //반드시 value로 해줘야 함. 다른걸로 하면 오류남. 
                                                             //우리가 선언하지 않았지? 이건 미리 예약어와 같이 누군가 만들어놓은 변수. 
                                                // 은닉성 보장 private set으로 변경
                                                // 아니면 아예 set 자체를 지워버릴 수도 있겠지. 그러면 타클래스에서 수정을 못함.
                                                // 그렇게 되면 같은 클래스에서도 프로퍼티를 이용해서 수정을 못하니까 변수로 직접 값을 매김.

    public int SalaryP2 { get { return salary + bonus;} set{ if(value < 0) salary = 10; else salary = value; } }

    // Start is called before the first frame update
    void Start()
    {
        SalaryP = 10; // 이 값이 value로 들어가고 private int salary 로 들어감.

        salary = 10; // set 자체를 지우고 변수로 값을 직접 매김.

        print(SalaryP);

        Bonus = 10;
        print(Bonus);

        // 프로퍼티의 대표적인 예 : 배열 Length
        //int[] a;
        //a.Length{ //get; } // 스패너 모양은 다 프로퍼티 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
