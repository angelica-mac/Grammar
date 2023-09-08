using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 21 코루틴 2번째 방법 : 문자열
public class Part21B : MonoBehaviour
{
    Coroutine mycouroutine1; 

    // Start is called before the first frame update
    void Start()
    {
        mycouroutine1 = StartCoroutine(LoopA()); // 파라미터 여러개 (LoopA(1,3,5))
        StartCoroutine("LoopB"); // 문자열을 통해서, 단점 : 과부화, 성능 저하. 파라미터 개수 1개. ("LoopB",3)
        StartCoroutine(Stoooop()); 

        IEnumerator LoopA() 
        {
            for (int i = 0; i < 100; i++)
            {
                print("i의 값=" + i);
                yield return null;  
                yield return new WaitForSeconds(1f);
            }
        }

        IEnumerator LoopB()
        {
            for (int x = 0; x < 100; x++)
            {
                print("x의 값=" + x);
                yield return new WaitForSeconds(1f);

            }
        }

        IEnumerator Stoooop()  // 코루틴 중단시키는 방법.
        {
            yield return new WaitForSeconds(2f);
            StopCoroutine(mycouroutine1); 
            yield return new WaitForSeconds(2f);
            StopCoroutine("LoopB"); // 똑같이 문자열만 넣어주면 됨.

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
