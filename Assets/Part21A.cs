using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 21 코루틴 1번째 방법 
public class Part21A : MonoBehaviour
{
    Coroutine mycouroutine1;  // 먼저 코루틴 클래스를 만들고
    Coroutine mycouroutine2;


    // Start is called before the first frame update
    void Start()
    {
        mycouroutine1 = StartCoroutine(LoopA()); // 만들어준 클래스와 연결
        mycouroutine2 = StartCoroutine(LoopB()); // 이 변수를 통해서 중지시켜줌.
        StartCoroutine(Stoooop()); // 실행시켜 줌.

        // LoopA 와 LoopB는 순차적으로 진행. 이걸 동시에 진행시키는 기능이 코루틴 일종의 병렬 처리 개념. (실제 병렬처리는 아니지만 그렇게 보이도록 만들어줌.)
        //StartCoroutine 안에 넣어줘야 함.

        IEnumerator LoopA() // 코루틴 방법 : void를 IEnumerator로 변경. 
        {
            for (int i = 0; i < 100; i++)
            {
                print("i의 값=" + i);
                // 코루틴 반드시 시간관련 문법 넣어줘야 함.
                yield return null;  // yield return 일정시간 만큼 대기. null 추가하면 한 프레임 대기.
                yield return new WaitForSeconds(1f); // 괄호안의 시간 만큼 대기. 1f 1초
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
      //    StopCoroutine(LoopA());  이렇게하면 될 것 같지만 이 기능은 수행되지 않음. StopCoroutine은 반드시 정해진 형식을 따라야 함.
            StopCoroutine(mycouroutine1); // 이렇게 해야 구현됨.
            yield return new WaitForSeconds(2f);
            StopCoroutine(mycouroutine2);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
