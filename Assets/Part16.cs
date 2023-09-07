using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 16 인터페이스 : 다중상속 가능. 뼈대 제공. 
abstract public class A : MonoBehaviour  // 매서드가 추상이면 클래스도 추상으로 만들어줘야 함
{
    public int a; // 변수 선언
    abstract public void ABC();  // 추상 매서드 만드는 법 : abstract + 미완성 상태
}
abstract public class B : MonoBehaviour  // 추상클래스를 하나 더 만들었어.
{
    abstract public void BBC();
}
interface ITest
{
    void CBC();
 // int a; // 오류. 인터페이스는 변수 입력할 수 없음.
 // 인터페이스는 한정적 : 함수, 프로퍼티, 인덱서, 이벤트 4개만 올 수 있음.
 // 뼈대만 제공하기 때문에 기능을 완성하면 안되고 선언만 해야 함.
 // 프로퍼티로 예를 들어 보자.
 int salaryP{ get; set; }
}
interface ITest2 : ITest  // interface끼리 서로 상속도 가능함.
{

}

public class Part16 : A, ITest2      // 상속받게 만들어 줌. 자식클래스에서 미완성 함수 ABC를 완성시켜줘야 함.
                                    // 쉽게 구현하는 방법 : 마우스 가져다 대면 나오는 Quick Fix 클릭 Implement abstract class 클릭
{                                   // A B 둘다 상속 받게 만들고 싶어. 그럴 때 사용하는게 인터페이스.
                                    // ITest2를 상속 시킴으로서 ITest까지 상속시키는 결과.(interface끼리 서로 상속 가능.)
    public int salaryP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void ABC()  // 일반 클래스는 재정의할 때 override 있음.
    {
        // throw new System.NotImplementedException();
        // 지우고 ABC 함수의 간단한 기능을 만들어 줄 수 있음.
        print("aa");
        a = 5; // 변수 가져다 쓸 수 있음 자기 것처럼.
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
