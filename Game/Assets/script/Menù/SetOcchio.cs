using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOcchio : Slide
{
    public void OnEnable(){
         start_slide(1,GestioneTwoC.oPigro==GestioneTwoC.occhioPigro.destro?10:0);
       
    }
    void Update()
    {
        changeDot(false);
        textValue.text=(((int)getY())==10?"Destro":"Sinistro");
         if(Input.GetButtonDown("x")){
               GestioneTwoC.oPigro=((int)getY())==10?GestioneTwoC.occhioPigro.destro:GestioneTwoC.occhioPigro.sinistro;
       }
    }
}
