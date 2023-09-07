using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 16 인터페이스 : 다중상속 가능. 뼈대 제공. 
abstract public class A : MonoBehaviour  // 매서드가 추상이면 클래스도 추상으로 만들어줘야 함
{
    abstract public void ABC();  // 추상 매서드 만드는 법 : abstract + 미완성 상태
}
abstract public class B : MonoBehaviour  // 추상클래스를 하나 더 만들었어.
{
    abstract public void BBC();
}
interface ITest
{
    void CBC();
}

public class Part16 : A, ITest      // 상속받게 만들어 줌. 자식클래스에서 미완성 함수 ABC를 완성시켜줘야 함.
                                    // 쉽게 구현하는 방법 : 마우스 가져다 대면 나오는 Quick Fix 클릭 Implement abstract class 클릭
{                                   // A B 둘다 상속 받게 만들고 싶어. 그럴 때 사용하는게 인터페이스.
    public override void ABC()  // 일반 클래스는 재정의할 때 override 있음.
    {
        // throw new System.NotImplementedException();
        // 지우고 ABC 함수의 간단한 기능을 만들어 줄 수 있음.
        // print("aa");
    }

    public void CBC()  // 인터페이스는 재정의할 때 override 없음.
    {
        print("cbc");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
