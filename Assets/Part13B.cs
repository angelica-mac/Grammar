using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part13B : Part13A 
{ //        (student)  (Human) 상속

    string schoolName;

    // Start is called before the first frame update
    void Start()
    {
        schoolName = "쪼유 초등학교";
        HumanName = "쪼유";
        HumanAge =8;

        Info();
    }

    protected override void Info()
    {       // 재정의
        base.Info(); // base : 부모클래스
        print("나는 학생입니다."); 
    }
}
