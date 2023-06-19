using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2 : MonoBehaviour
{
    long a = 4000000000;

    //정수 자료형 byte    (0 ~ 255)       1byte.
    //정수 자료형 sbyte   (-128 ~ +127)   1byte.
    //정수 자료형 short   (-3만 ~ +3만)    2byte.
    //정수 자료형 integer (-20억 ~ +20억)  4byte.
    //정수 자료형 long    (20억 초과)       8byte.

    float f = 4.00001f;
    double d = 4.00001;
    decimal m = 4.00001m;

    //실수 자료형 float     0.0000000000000001
    //실수 자료형 double    0.000000000000000000000000001 float보다 오차범위가 더 작음. 신뢰도가 더 높음.
    //실수 자료형 decimal   오차가 거의 없다고 봐도 됨. cf) 화폐, 정밀한 계산 

    string s = "1234abcfㄱㄴㄷㄹ!@#$"; //한글,영어,숫자,특수문자 다 됨. 큰따옴표
    char c = 'A'; //0065(유니코드 숫자) 유니코드로 변환해서 기억시킬 수 있음. 한글자만 입력가능. 작은따옴표
}
   