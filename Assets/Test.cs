using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 1 + x = 101
    // 숫자1 상수
    // x 변수
    int x = 100; 
    // Start is called before the first frame update
    void Start()
    {
        print(x); // 100

        x = -500;

        print(x); //-500

        x = x -500;

        print(x); //-1,000
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
