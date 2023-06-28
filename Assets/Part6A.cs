using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6A : MonoBehaviour
{
    int input = 5;
    int num = 10;
    bool result;

    // Start is called before the first frame update
    void Start()
    {
        result = input > num;

        if(result) // True
        {
            print("input의 값이 num보다 큽니다.");
        }

        if(!result) // False
        {
            print("input의 값이 num보다 작습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
