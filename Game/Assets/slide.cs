/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
{
    public GameObject dot;//oggetto dot 
    private float sen;
    public float step;//incremento posizione dot
    public float multi;
    public TextMeshPro text;
    public bool status;//indicatore di selezione 
    public GameObject statusText;
    void Start()
    {
       
    }
   void OnEnable(){
         dot.transform.localPosition=Vector3.right*(-6+Camera.sensibility/(step*multi)); 
   }
    void Update()
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
            sen=((dot.transform.localPosition.x+6)*step);
            text.text=((int)sen+"");
         if(Input.GetButtonDown("x")){
               Camera.sensibility=sen*multi;
         }
        
      }else
         statusText.SetActive(false);
   }
}
*/