using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class shoot : MonoBehaviour
{
    public GameObject sampleBullet;
    public float pressLevels;
    public float mTimeShoot;
    public float timeShoot=0f;
     public InputActionAsset controller;
    void Start()
    {
       
    }
    void shootOn(){
         
          
        }
    void Update()
    {  
        float rt=Input.GetAxis("rt_ps")+Input.GetAxis("rt_xbox");//in modo da poter usare sia controller xbox che playStation
        if(rt>0f && SetUp.command){
             float t=(int)(pressLevels*rt+1);
             if(timeShoot>=mTimeShoot/t){
               timeShoot=0f; 
               GameObject o=Instantiate(sampleBullet,transform.position,transform.rotation);
              
           }
           timeShoot+=Time.deltaTime;
        }
       
    }
   
 
}
