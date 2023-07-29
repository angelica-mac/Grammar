using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part14B : MonoBehaviour
{
    Part14C mysalary = new Part14C();


    // Start is called before the first frame update
    void Start()
    {
        print(mysalary.GetSalary());

      //  mysalary.SetSalary(55);
    }

}
