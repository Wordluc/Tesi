using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject scelta;
    public enum stati{setting,exit,menu};
    public stati currentButton;
    public stati finestre;
    public GameObject setting_back;
    public GameObject exit_back;
    public GameObject setting;
    void Start()
    {
        setting_back.SetActive(true);
        exit_back.SetActive(false);
        currentButton=stati.setting;
    }
    
    void Update()
    {    
        switch(finestre){
            case stati.exit:
              if(currentButton==stati.exit)
                 Application.Quit();
            break;
            case stati.setting:
                 setting.SetActive(true);
                 scelta.SetActive(false);
            break;
            case stati.menu:
                 setting.SetActive(false);
                 scelta.SetActive(false);
            break;
        }
        if(Input.GetButtonDown("option_right")){
            if(statiMenu==stati.scelta)
                statiMenu=stati.close;
            else if(statiMenu==stati.close)
                statiMenu=stati.scelta;
        }
        if(statiMenu==stati.scelta){
            scelta.SetActive(true);
            SetUp.command=false;
        }
        if(statiMenu==stati.close){
            scelta.SetActive(false);
            SetUp.command=true;
        }
      if(Input.GetAxis("d_pad_y")==-1)
        currentButton=stati.setting;
      if(Input.GetAxis("d_pad_y")==1)
         currentButton=stati.exit;
        
        if(currentButton==stati.setting){
           setting_back.SetActive(true);
           exit_back.SetActive(false);
        }else{
             setting_back.SetActive(false);
           exit_back.SetActive(true);
        }

         if(Input.GetButtonDown("x")){
            
            else{
              
              
            }
               
         }

    }
}
