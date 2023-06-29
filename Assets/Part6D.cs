using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6D : MonoBehaviour
{   
    int input = 10;
    int num = 10;
    bool result;

    // Start is called before the first frame update
    void Start()
    {
        int temp  = input == num ? 50: 100; // 삼항 연산자 True(50): False(100);
        // 1항          2항         3항
        print(temp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
