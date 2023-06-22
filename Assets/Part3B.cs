using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3B : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    void FloatToInt(float _parameter, float _parameter2) 
    {   
        intValue = (int)(_parameter + _parameter2);
        print(intValue);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        FloatToInt(floatValue, floatValue2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
