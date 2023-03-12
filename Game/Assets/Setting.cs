using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : Choice
{
    void Update()
    {
        scroll();
        if(Input.GetButtonDown("option_right") || Input.GetButtonDown("b"))
           gameObject.SetActive(false);
    }
}
