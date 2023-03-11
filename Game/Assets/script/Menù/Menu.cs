using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject scelta;
    public enum stati{setting,close,menu};
    public stati currentButton;
    public stati finestre;
    private stati store_finestre;
    public GameObject setting_back;
    public GameObject exit_back;
    public GameObject setting;
    public Camera camera;
    void Start()
    {
        setting_back.SetActive(true);
        exit_back.SetActive(false);
    
    }
    
    void Update()
    {   
        switch(finestre){
            case stati.close:
                 setting.SetActive(false);
                 scelta.SetActive(false);
                 if(Input.GetButtonDown("option_right")){
                     finestre=stati.menu;
                       SetUp.setCommand("chiusura menù",false);
                 }
                
            break;
            case stati.setting:
                 setting.SetActive(true);
                 scelta.SetActive(false);
            break;
            case stati.menu:
                 scelta.SetActive(true);
                 setting.SetActive(false);
                 if(Input.GetAxis("d_pad_y")==-1)
                       currentButton=stati.setting;
                 if(Input.GetAxis("d_pad_y")==1){
                       currentButton=stati.close;
                       Application.Quit();
                 }
                 if(Input.GetButtonDown("x"))
                     finestre=currentButton;
                 if(Input.GetButtonDown("option_right") || Input.GetButtonDown("b")) {
                     finestre=stati.close;
                 }
            break;
        }
        if(store_finestre!=finestre){//catturare cambio variabile
            if(finestre==stati.close){
                camera.resetV();
                SetUp.setCommand("chiusura menù",true);
            }
            store_finestre=finestre;
        }
   
     
        
        if(currentButton==stati.setting){
           setting_back.SetActive(true);
           exit_back.SetActive(false);
        }else{
             setting_back.SetActive(false);
           exit_back.SetActive(true);
        }


    }
}
