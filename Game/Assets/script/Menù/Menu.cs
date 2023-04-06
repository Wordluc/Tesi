using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject scelta;
    private  string lastUse="chiusura menu";
    public void setActive(string use,bool value){
          scelta.SetActive(value);  
          Debug.Log(use); 
           
          lastUse=use;
    }
    public string getLastUse(){
        return lastUse;
    }
    void Update()
    {   
           
        if(Input.GetButtonDown("option_right")){
            if(getLastUse()=="apertura menu" || getLastUse()=="chiusura setting"){
                setActive("chiusura menu",false);
                SetUp.setCommand("chiusura menu",true);
            }else
            if(getLastUse()=="chiusura menu"){
               setActive("apertura menu",true);
               SetUp.setCommand("apertura menu",false);
            }
        }
         if(Input.GetButtonDown("b")){
               setActive("chiusura menu",false);
               SetUp.setCommand("chiusura menu",true);
         }
    
    }
}
