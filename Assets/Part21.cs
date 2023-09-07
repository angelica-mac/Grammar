using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 21 코루틴
public class Part21 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoopA(); 
        LoopB();
        // LoopA 와 LoopB는 순차적으로 진행. 이걸 동시에 진행시키는 기능이 코루틴

        void LoopA()
        {
            for (int i = 0; i < 100; i++)
            {
                print("i의 값=" + i);
            }
        }

        void LoopB()
        {
            for (int x = 0; x < 100; x++)
            {
                print("i의 값=" + x);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
