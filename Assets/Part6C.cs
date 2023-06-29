using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6C : MonoBehaviour
{
    int input = 14;  // string input = "가나다" 텍스트도 가능.
    int num = 10;
    bool result;

    // Start is called before the first frame update
    void Start()
    {
        switch(input)
        {
            case 10:
            print("input의 값이 10입니다.");
            break;              // switch자체를 파괴. 반드시 입력.

            case 11:
            print("input의 값이 11입니다.");
            break;

            case 12:
            print("input의 값이 12입니다.");
            break;

            default: // else 라고 보면 됨.
            print("그 외의 경우");
            break;
        }

        // 같은 결과값. 다른 함수.

        if(input == 10)
        print("input의 값이 10입니다.");

        else if(input == 11)
        print("input의 값이 11입니다.");

        else if(input == 12)
        print("input의 값이 12입니다.");

        else
        print("그 외의 경우");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
