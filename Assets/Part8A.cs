using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part8A : MonoBehaviour
{
    int exp1 = 50;
    int exp2 = 100;
    int exp3 = 150;
    int exp4 = 200;

    // 1차원 배열
    int[] exp = {50, 100, 150, 200};

    int[] array = new int[10]; // 인덱스는 0부터 9까지

    int[] array2; // 껍데기만 만들어두고 배열의 크기를 나중에 지정해 줄 수도 있음.

    // 2차원 배열 (1차원 배열 2개)
    int[,] array3 = {{1,2,3,4,5},{10,20,30,40,50}};

    // 3차원 배열 (2차원 배열 2개)
    int[,,] arrya4 = {{{1,2,3,4,5},{10,20,30,40,50}},{{1,2,3,4,5},{10,20,30,40,50}}};


    // Start is called before the first frame update
    void Start()
    {   // 3차원 배열 출력
        print(arrya4[1,1,2]); // 30
        print(arrya4[0,0,3]); // 4

        // 2차원 배열 출력
        print(array3[1,3]); // 40
        print(array3[0,1]); // 2

        array2 = new int[10]; //  껍데기만 만들어두고 배열의 크기를 나중에 지정해 줄 수도 있음.
        array2 = new int[exp.Length]; 

        print(exp[0]); // C#에서 배열 1번째는 0
        print(exp[1]);
        print(exp[2]);
        print(exp[3]);
    //  print(exp[4]);  // 오류. 범위 밖.

        print(exp.Length); // 4 원소의 개수

        for( int i = 0; i <= 3; i++)
        {
            print(exp[i]);
        }

        for( int i = 0; i < exp.Length; i++)  // Length 배열의 크기 // = 을 빼주거나 exp.Length-1 
        {
            print(exp[i]);
        }

        exp[3] = 500;   // 배열의 원소 값은 변경할 수 있어도
        print(exp[3]);

        exp[4] = 600;   // 한번 정해진 배열은 변경할 수 없음.
        print(exp[4]);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
