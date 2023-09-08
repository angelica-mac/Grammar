using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 21 코루틴 4번째 방법 : StopAllCoroutines
// C# 전처리 기능 : 숨기기 펼치기 기능. region endregion
public class Part21D : MonoBehaviour
{
    private IEnumerator mycouroutine1; 

    // Start is called before the first frame update
    void Start()
    {
        mycouroutine1 = LoopA(); 
        StartCoroutine(mycouroutine1);
        StartCoroutine(Stoooop()); 

#region Loop
        IEnumerator LoopA() 
        {
            for (int i = 0; i < 100; i++)
            {
                print("i의 값=" + i);
                yield return null;  
                yield return new WaitForSeconds(1f);
            }
        }
#endregion Loop

        IEnumerator Stoooop()  
        {
            yield return new WaitForSeconds(2f);
            StopAllCoroutines(); // 동작중인 모든 코루틴을 멈춤.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
