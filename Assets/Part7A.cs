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

        for( ; ; )  // 다 채울 필요 없음. 
        {                   // 1항 초기값 설정해줬으므로 입력 안해도 됨.
            if(num > 10)  // 2항 대신 조건문 입력.
                break; // ""첫번째"" 반복문 탈출. 조건문 탈출.
            print(num);
            num += 2; // 3항 지우고 식으로 써줘도 무방.
        }

        for( ; ; ) 
        {                 
            if(num > 10)  
                break; 
            print(num);
            num += 2; 
        }

        for(int i = 0; i < 11; i++) // 2중 for문
        {
            for( ; ; )  // break와 가까운 첫번째 for문만 탈출.
            {                 
                if(num > 10)  
                    break; 
                print(num);
                num += 2; 
            }
        }

        for( ; ; ) 
        {             
            num++;

            if(num % 2 == 0)
                continue; // 해당 회차를 끝냄. 다음 회차 시작.

            print(num);

            if(num > 10)  
                break; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
