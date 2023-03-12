using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scelta : Choice
{
   


    void Update()
    {
        scroll();
        if(Input.GetButtonDown("option_right")|| Input.GetButtonDown("x"))
           gameObject.SetActive(false);
    }
}
