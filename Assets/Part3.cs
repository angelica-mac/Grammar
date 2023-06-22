using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    void FloatToInt() 
    {
        intValue = (int)floatValue;
    }

    // Start is called before the first frame update
    void Start()
    {
        FloatToInt();

        print(intValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
