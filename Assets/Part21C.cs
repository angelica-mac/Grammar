using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 21 코루틴 3번째 방법 : 문자열
public class Part21C : MonoBehaviour
{
    private IEnumerator mycouroutine1;  // 직접 변수로 사용

    // Start is called before the first frame update
    void Start()
    {
        mycouroutine1 = LoopA(); // 3번째 방법은 파라미터를 여러개 쓸 때 유리. 1번째 방법은 일일이 나열.
        StartCoroutine(mycouroutine1);
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

        IEnumerator Stoooop()  // 코루틴 중단시키는 방법.
        {
            yield return new WaitForSeconds(2f);
            StopCoroutine(mycouroutine1); 

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
