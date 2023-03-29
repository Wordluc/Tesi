using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scelta : Choice
{
   public bool status;
   public bool CanOff;

    void Update()
    {
        scroll();
        if(Input.GetButtonDown("option_right") && CanOff){
           gameObject.SetActive(false);
           SetUp.setCommand("Chiusura menu scelta",true);
        }
    }
}
