using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part7B : MonoBehaviour
{
    // for문 : 반복 횟수가 명확할 때
    // while문 : 반복 횟수가 명확하지 않을 때
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        while(true)
        {
            num++;
            if(num > 10)
                break;
            print(num);
        }

         while(num < 10)
        {
            num++;
            print(num);
        }

        do              // 무조건 1회차는 실행시켜 놓고 
        {   num++;
            print(num);
        } while(num < 10); // 나중에 조건을 보겠다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
