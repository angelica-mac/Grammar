using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sum : MonoBehaviour
{   
    int x = 100;
    int y = 100;
    int summary;

    // Start is called before the first frame update
    void Start()
    {
        summary = x + y;

        print(summary);

        print(-summary);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
