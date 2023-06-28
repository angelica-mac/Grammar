using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6B : MonoBehaviour
{    
    int input = 10;
    int num = 10;
    bool result;

    // Start is called before the first frame update
    void Start()
    {
        if (input == num) 
        {
            print("input의 값이 num과 같습니다.");
        }

        else if (input > num) 
        {
            print("input의 값이 num보다 큽니다.");
        }

        else if (input < num)
        {
            print("input의 값이 num보다 작습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


