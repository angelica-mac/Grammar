using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14A : MonoBehaviour
{
    private int salary;

    public int SalaryP { get { return salary; }  set { salary = value; } }
                       // 읽기                  // 쓰기


    // Start is called before the first frame update
    void Start()
    {
        SalaryP = 10;
        print(SalaryP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
