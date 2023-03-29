using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Slide : Option
{
    public GameObject dot;//oggetto dot 
    public float step;//incremento posizione dot
   
 
    public GameObject statusText;//indicatore di stato
    private float yt;
      public TextMeshPro textValue;
    void Start()
    {
       
    }
   public void start_slide(float multi,float y){
         dot.transform.localPosition=Vector3.right*(-5+y/multi); 
          yt=((dot.transform.localPosition.x+5));
            textValue.text=((int)yt+"");
   }
   public float getY(){
      return yt;
   }
    public void changeDot(bool deltaT=true)
    {   
      if(status){
         float timeDelta=deltaT?Time.deltaTime:1;
         statusText.SetActive(true);
         if(Input.GetAxis("d_pad_x")==1){
            if(dot.transform.localPosition.x<5){
               dot.transform.localPosition+=Vector3.right*step*timeDelta; 
            }
         }else if(Input.GetAxis("d_pad_x")==-1)
            if(dot.transform.localPosition.x>-5){
               dot.transform.localPosition-=Vector3.right*step*timeDelta;
            }
       
            yt=((dot.transform.localPosition.x+5));
            
        
        
      }else
         statusText.SetActive(false);
   }
}
