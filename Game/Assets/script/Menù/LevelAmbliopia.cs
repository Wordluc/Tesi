using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelAmbliopia : Slide
{ 
    public float multi;
    void Start()
    {
        
    }

      
    public void OnEnable(){
         start_slide(multi,SetUp.trasparency);
       
    }
    void Update() {
       changeDot();
       textValue.text=((int)(10-getY())+"");
       if(Input.GetButtonDown("x")){
               SetUp.trasparency=getY()*multi;
       }
    }
}
