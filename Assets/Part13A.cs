using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Part13A : MonoBehaviour
{ //        (Human)

protected string HumanName;
protected int HumanAge;

// protected  // 상속받은 클래스만 사용가능
// public // 타 클래스 모두 사용가능
// private // 지정 클래스에서만 사용가능

// 함수 상속
protected virtual void Info()
{       //  가상 함수 : 상속받을 class에서 재정의(override)

    print("나는 인간입니다.");
}

abstract protected void Name(); // 추상함수 : 자식클래스에서 기능을 완성시켜야 하는 함수. 미완성인 상태로 둠. 완성은 자식클래스에서.
                                // 추상함수를 쓰면 class도 abstract 붙여줘야 함.

}
