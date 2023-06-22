using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3C : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    int FloatToInt(float _parameter, float _parameter2) 
    // void 에서 int 로 변경, 반환값이 없기 때문에 오류 생김 
    {   
        intValue = (int)(_parameter + _parameter2);
        print(intValue); // 31

        return 4; // 반환값 입력 오류 해결.
    }
    
    // Start is called before the first frame update
    void Start()
    {
        intValue = FloatToInt(floatValue, floatValue2); // 이 결과값이 4가 됨.
        print(intValue); //4
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
