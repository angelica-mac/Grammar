using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part13A : MonoBehaviour
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

}
