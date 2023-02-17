using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelAmbliopia : MonoBehaviour
{
    public GameObject dot;
    public float step;
    public float multi;
    public TextMeshPro text;
    public bool status;
    public GameObject statusText;
    public GestioneTwoC cam;
    private GestioneTwoC.pigroGrandezza store_dim;
    void Start()
    {
        
    }

     void OnEnable(){
         dot.transform.localPosition=(cam.occhioDiff==GestioneTwoC.pigroGrandezza.grande?-5:5)*Vector3.right;
   }
    void Update()
    {   
      if(status){
         statusText.SetActive(true);
         if(Input.GetAxis("d_pad_x")==1){
            if(dot.transform.localPosition.x==-5){
               dot.transform.localPosition=Vector3.right*5; 
               store_dim=GestioneTwoC.pigroGrandezza.piccolo;
               text.text="piccolo";
            }
         }else if(Input.GetAxis("d_pad_x")==-1)
            if(dot.transform.localPosition.x==5){
               dot.transform.localPosition=Vector3.right*(-5); 
                store_dim=GestioneTwoC.pigroGrandezza.grande;
               text.text="grande";
            }  
         if(Input.GetButtonDown("x"))
             cam.occhioDiff=store_dim; 
      }else
         statusText.SetActive(false);
   }
}
