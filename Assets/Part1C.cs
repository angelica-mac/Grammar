using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1C : MonoBehaviour
{
    int a = 100;
    long b = 100;
    float c = 100.15f;
    long sum; // long은 int를 포함하고 있어서 오류가 안생김. int는 long에 속함으로 오류 생김.
    float sum2;

    // Start is called before the first frame update
    void Start()
    {
        sum = a + b;
        sum = (int)(a + c); // 강제로 해결하는 방법 (캐스트) 실수형을 정수형으로 변환함.
        sum2 = a + c;

        print(sum2);
        print(sum);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
