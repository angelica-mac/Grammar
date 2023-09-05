using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int [5];
        // int를 예로 들었지만 string이나 float도 가능.
        // arraylist list 같은 class타입도 인덱스 활용 가능.
        // 인덱스가 붙어 있는 것들은 모두 인덱스를 활용해 줄 수 있다.
    public int this[int index]  // this : 해당 클래스를 가리키는 예약어. 인덱서 이름.
    {                           // 인덱서도 프로퍼티의 한 종류. get set 수정 가능. 오류가 뜨지 않게 로직 보완 가능.
        get { 
                if(index >= temp.Length)
                { 
                    Debug.Log("인덱스가 너무 큽니다.");
                    return 0; 
                }       // int 타입으로 return값을 입력해줘야 하기 때문. 의미없는 숫자 0.
              else 
                { 
                    return temp[index];
                }  
            }
        set { if(index >= temp.Length) Debug.Log("인덱스가 너무 큽니다."); else temp[index] = value; } 
                                    // print 사용 불가 Record class는 MoBehaviour를 상속받지 않았기 때문.
                                    // Debug.Log() -> print와 같은 기능.
    }
            
}

public class Part15 : MonoBehaviour
{   
    Record record = new Record();
    //temp에 접근하려면 class를 변수 타입으로 바꿔야겠지.생성도 바로 해줌.

    // Start is called before the first frame update
    void Start()
    {
        record.temp[3] = 5;  //  좀 길어.
    //  record[3] = 5; 이런식으로 활용했으면 좋겠지? 변수를 자체의 배열처럼. 이럴때 존재하는게 바로 인덱서.

        record[3] = 5;
        record[5] = 5; // [5]는 [int index]로 대입. 5는 value로 대입.
        // 근데 오류가 있어. 배열이 5면 01234 인데 5가 입력. 범위 밖. 인데스를 직접 수정해줄 수 있음.

        print(record[3]);
        print(record[5]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
