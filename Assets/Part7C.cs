using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part7C : MonoBehaviour
{
    string text = "가나다라마바사";

    // Start is called before the first frame update
    void Start()
    {          //캐릭터
        foreach(char a in text) // 큰 덩어리를 알맹이 개수만큼 쪼개줌.
        {
            print(a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
