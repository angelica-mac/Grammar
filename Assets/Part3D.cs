using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3D : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    int FloatToInt(float _parameter, float _parameter2) 
    {   
        return Multiply((int)(_parameter + _parameter2));   // 31
        // return을 함수 안에서 만나게 되면 뒤에 어떤 코드가 오든지 무시됨.

        //함수 내에서 다른 함수를 호출 시킬 수도 있음.
    
    int Multiply(int _parameter)
    {
        return _parameter * _parameter;  // 31 * 31
    }


        // print(intValue); 무의미한 코드.
    }
    
    // Start is called before the first frame update
    void Start()
    {
        print(FloatToInt(floatValue, floatValue2)); // 31
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
