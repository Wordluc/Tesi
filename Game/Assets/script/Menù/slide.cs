using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class slide : option
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
    public void changeDot()
    {   
      if(status){
         statusText.SetActive(true);
         if(Input.GetAxis("d_pad_x")==1){
            if(dot.transform.localPosition.x<5){
               dot.transform.Translate(Vector3.right*step); 
            }
         }else if(Input.GetAxis("d_pad_x")==-1)
            if(dot.transform.localPosition.x>-5){
               dot.transform.Translate(Vector3.left*step); 
            }
       
            yt=((dot.transform.localPosition.x+5));
            
        
        
      }else
         statusText.SetActive(false);
   }
}
