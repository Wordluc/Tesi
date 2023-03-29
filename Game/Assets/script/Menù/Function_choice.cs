using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_choice:MonoBehaviour{
    public GameObject panel;
    public void goOn(){
         panel.SetActive(true);
    }
    public void goOff(){
         panel.SetActive(true);
    }
    public void exit(){
        Application.Quit();
    }
}
