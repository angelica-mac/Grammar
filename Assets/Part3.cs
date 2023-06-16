using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;
    void FloatToInt (float _parameter, float _parameter2, string _stringParm = "디폴트값") 
         //내가 만든 로직                                       // 디폴트 값 입력시 필수 매개변수 다음에 와야함 (맨처음에 못옴)
    //void 반환값이 없을때                                       // 디폴트 값 입력 안하면 디폴트값에 입력된 값이 출력.
    //return 반환 -> void 지우고 int 입력후

    //함수 내에서 다른 함수 호출시킬 수도 있음.
    //int Multiply(int _parameter)
        //return _parameter * _parameter;
    
    {
        intValue = (int)(_parameter + _parameter2);
        // 유의미하게 만들어볼게.
        // return (int)(_parameter + _parameter2); // 31
        // print(floatValue); // return 뒤에 어떤 코드가 와도 무시됨. // 경고 CS0162 // 있어봐야 의미 없는 코드
        print(intValue);
        print(_stringParm); // 디폴트값 출력.

        //여기에 return 4; 입력하면 -- 무의미하지.
    }


    // Start is called before the first frame update
    void Start()
    {
        FloatToInt(floatValue,floatValue2); // "입력"하면 디폴트값 대신 입력됨.   
        //FloatToInt(float 10.5f, float 20.5f); // 값을 직접 입력해도 됨.
        //intValue = FloatToInt(floatValue,floatValue2); (return 4;)
        //print(intValue); 결과값 4로 나옴.(return 4;) 
        //print(FloatToInt(floatValue,floatValue2)); // 31
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
