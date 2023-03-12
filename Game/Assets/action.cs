using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    public enum type{close_open_W,quit};
    public type a;
    public GameObject panel;
    public void go(){
        switch(a){
            case type.close_open_W:
               if(panel.activeSelf)
                  panel.SetActive(false);
                else 
                  panel.SetActive(true);
               break;
            case type.quit:
               Application.Quit();
               break;   
        }
    }

}
