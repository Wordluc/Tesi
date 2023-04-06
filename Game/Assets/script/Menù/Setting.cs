using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : Choice
{
    public Menu menuBef;
    public bool dontC=false;
    void Update()
    {
        scroll();
        if(Input.GetButtonDown("option_right") && !dontC){
           SetUp.setCommand("Chiusura setting",true);
           gameObject.SetActive(false);
           
        }
        if(Input.GetButtonDown("b") && !dontC){
             gameObject.SetActive(false);
            if(menuBef!=null){
               menuBef.setActive("chiusura setting",true);
               
               }
        }
    }
}
