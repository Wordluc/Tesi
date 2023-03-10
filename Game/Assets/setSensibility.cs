using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class setSensibility : slide
{
   public float multi;
    
   void OnEnable(){
         setUp(multi,Camera.sensibility);
   }
   void Update() {
       changeDot();
       textValue.text=((int)getY()+"");
       if(Input.GetButtonDown("x")){
               Camera.sensibility=getY()*multi;
       }
   }
}
