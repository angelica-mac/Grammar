using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3A : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    void FloatToInt() //함수 첫글자는 대문자(약속)
    //빈,공허 
    {
        intValue = (int)floatValue;
    }

    // Start is called before the first frame update
    void Start()
    {
        FloatToInt();
        FloatToInt(); // 여러번 호출하고 싶으면 함수만 적어주면 되겠지.

        print(intValue); // 10 출력
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
