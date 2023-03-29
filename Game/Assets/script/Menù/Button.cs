using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Option
{
    public GameObject back;
    public action a;
    public GameObject panel_menu;
    void Update()
    {
        if(status){
           back.SetActive(true);
           if(Input.GetButtonDown("x")){
              a.go();
              if(panel_menu!=null){
                panel_menu.SetActive(false);
              }
           }
        }else 
           back.SetActive(false);
           
    }
}
