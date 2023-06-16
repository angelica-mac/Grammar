using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sum : MonoBehaviour
{   
    int x = 100;
    int y = 100;
    int summary; // public class랑 이름 똑같으면 안됨

    // Start is called before the first frame update
    void Start()
    {
        summary = x + y;

        print(summary); // 200

        print(-summary); // -200

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
