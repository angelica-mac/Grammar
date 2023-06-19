using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1D : MonoBehaviour
{
    int a = 100;
    int c;
    
    string b;
    string d = "100";

    ushort au = 500; // short(-3만 ~ +3만) ushort(0 ~ +6만)

    bool aaa = true; 
    bool bbb = false; // true, false 만 기억할 수 있다.

    // Start is called before the first frame update
    void Start()
    {
        b = a.ToString(); // b = "100";
        print(b); // 문자 100

        c = int.Parse(d); // 문자열을 정수형으로 변환
        print(c); // 숫자 100
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
