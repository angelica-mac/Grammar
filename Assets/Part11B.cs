using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Youtube2
{
    public int a;
    public int b;
    public int c;

    public Youtube2(int _a, int _b, int _c)  // 생성자가 있으면 매우 편리하다. ㅌㄴ
    {
        a = _a; b = _b; c = _c;
    }
}

public class Part11B : MonoBehaviour
{   
    int a;

    Youtube2 angelica2 = new Youtube2( 1, 2, 3); // 선언, 생성 동시에 값까지 넣어주는 효과.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
