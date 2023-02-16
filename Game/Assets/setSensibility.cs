using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSensibility : MonoBehaviour
{
    public GameObject dot;
    public static float sensibility=1;
    public float step;
    public float multi;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetAxis("d_pad_x")==1){
           if(dot.transform.localPosition.x<5){
              dot.transform.Translate(Vector3.right*step*Time.deltaTime); 
           }
        }else if(Input.GetAxis("d_pad_x")==-1)
           if(dot.transform.localPosition.x>-5){
              dot.transform.Translate(Vector3.left*step*Time.deltaTime); 
           }
        if(Input.GetButtonDown("x")){
            sensibility=(dot.transform.localPosition.x+6)*multi;
        
        }
    }
}
