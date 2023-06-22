using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3B : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    void FloatToInt(float _parameter, float _parameter2, string _stringParm = "디폴트값") // 디폴트값 입력 앞에서 할 수 없고 뒤에서 해줘야 함.
    {   
        intValue = (int)(_parameter + _parameter2);
        print(intValue);
        print(_stringParm);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        FloatToInt(floatValue, floatValue2, "테스트"); // "테스트"대신 아무것도 입력 안해도 "디폴트값" 출력됨.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
