using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14B : MonoBehaviour
{
    Part14A mysalary = new Part14A();


    // Start is called before the first frame update
    void Start()
    {
      //  mysalary.SalaryP = 50; // 값을 입력할 수도 있고  // private set으로 변경했기 때문에 타클래스에서 접근 불가.

        print(mysalary.SalaryP); // 꺼내올 수도 있음. 은닉성 의미가 없음. // private set으로 변경.

      //  print(mysalary.GetSalary()); // 연봉검색. // Part14C

      //  mysalary.SetSalary(55);  // 연봉 임의수정 불가능. 은닉성 보장 
    }

}
