using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public Menu Menu;
    public setSensibility sen;
    public LevelAmbliopia lev;
    void Start()
    {
        sen.status=true;
        lev.status=false;
    }
    void Update()
    {
        if(Input.GetAxis("d_pad_y")==-1){
          sen.status=true;
          lev.status=false;
        }
         if(Input.GetAxis("d_pad_y")==1){
          sen.status=false;
          lev.status=true;
        }
        if(Input.GetButtonDown("b")){
            Menu.finestre=Menu.stati.menu;
           
        }
        if(Input.GetButtonDown("option_right")){
           Menu.finestre=Menu.stati.close;
        }
    }
}
