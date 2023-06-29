using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part7A : MonoBehaviour
{   
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        print(num++);
        print(num++);
        print(num++);
        print(num++);
        print(num++);

        for(int i = 0; i <= 10; i++) 
        {
            num = i;        
            print(num);
        }

        for(int num = 0; num <= 10; num++)  // i 지우고 for문 안에서 직접 num 입력해도 무방.
        {
            print(num);
        }

        for(int i = 0; i <= 10; i += 2) // 2씩 증가 i = i + 2
        {
            num = i;
            print(num);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
