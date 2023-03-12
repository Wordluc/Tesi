using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : Choice
{
    void Update()
    {
        scroll();
        if(Input.GetButtonDown("option_right"))
           gameObject.SetActive(false);
        if(Input.GetButtonDown("b")){
            SetUp.setCommand("Chiusura setting",true);
            gameObject.SetActive(false);
        }
    }
}
