using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetSensibility : Slide
{
   public float multi;
    
   void OnEnable(){
         start_slide(multi,Camera.sensibility);
   }
   void Update() {
       changeDot();
       textValue.text=((int)getY()+"");
       if(Input.GetButtonDown("x")){
               Camera.sensibility=getY()*multi;
       }
   }
}
