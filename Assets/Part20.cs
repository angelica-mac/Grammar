using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 오류의 예외 처리
public class Part20 : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;

    // Start is called before the first frame update
    void Start()
    {
        try // 예외처리 해주고 싶은 부분 try 블럭 안에 넣어줌.
        {
            c = a/b; // 결과값 오류남. DivideByZeroException: Attempted to divide by zero.
        }
            // DivideByZeroException - using system; 추가해줘야 자동완성 뜸.
        catch( DivideByZeroException ie ) // 어떤 오류를 잡을지 // Exception : 모든오류, DivideByZeroException 0으로 나누는 오류.
        {                     //관례상 ie를 주로 사용           // 오류가 걸리면 대신 실행할 명령어 입력해주면 됨.
            print(ie); // 어떤 오류에 걸렸는지 출력.
            b = 1;
            c = a/b;
            print(c);
        } 

        catch( NullReferenceException ie)  // catch 여러개 만들어 줄 수 있음. // 이런 식으로 오류 원인마다 다르게 대처할 수 있음.
        {
            print(ie);
        }                                             
        
        finally    // 오류가 있든 없든 마지막으로 실행할 명령어 코드
        {
            print(c);
        }

        throw new Exception("일부러 오류를 발생시킴"); // 일부러 오류 발생시킴. 이런 기능이 있다 정도만 알고 넘어가면 됨.
    }
}
