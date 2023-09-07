using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 람다식 델리게이트 형식매개변수 혼합 응용
public class Part18B : MonoBehaviour
{
    delegate void Mydelegate<T>(T a, T b);
    Mydelegate<int> mydelegate;

    // Start is called before the first frame update
    void Start()
    {
        mydelegate += ( int a, int b )=> print(a+b);  // 람다식
        mydelegate(3,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
