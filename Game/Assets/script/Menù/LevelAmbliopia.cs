using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelAmbliopia : Slide
{ 
    private bool lastPress;
    public float multi;
    void Start()
    {
        
    }

      
    public void OnEnable(){
         
          switch(SetUp.levelT){
                case SetUp.levelTrasparent.Facile:
                   start_slide(1,10);
                   
                break;      
                case SetUp.levelTrasparent.Medio:
                  start_slide(1,5f);
                break;
                case SetUp.levelTrasparent.Difficile:
                   start_slide(1,0);
                break;
          }
    }
    void Update() {
       if(lastPress==false)
          changeDot(false);
        lastPress=Input.GetAxis("d_pad_x")!=0?true:false;
       switch((int)getY()){
        case 10: textValue.text="Facile";
              break;      
        case 5: textValue.text="Medio";
              break;
        case 0: textValue.text="Difficile";
              break;
       }
       if(Input.GetButtonDown("x")){
            
            switch(textValue.text){
                case "Facile":
                   SetUp.levelT=SetUp.levelTrasparent.Facile;
                  
                break;      
                case "Medio":
                   SetUp.levelT=SetUp.levelTrasparent.Medio;
                
                break;
                case "Difficile":
                   SetUp.levelT=SetUp.levelTrasparent.Difficile;
                  
                break;
       }
               
       }
    }
}
