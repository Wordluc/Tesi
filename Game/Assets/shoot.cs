using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shoot : MonoBehaviour
{
    public GameObject sampleBullet;
    public float pressLevels;
    public float mTimeShoot;
    public float timeShoot=0f;
     public string command;
     public GameObject gun;
     public Vector3 originalP;
     public float resistThrill;
     public float forceThrill;
    void Start()
    {
       originalP=gun.transform.localPosition;
    }
    void shootOn(){
         
          
        }
    void Update()
    {  
        float rt=Input.GetAxis(command);//in modo da poter usare sia controller xbox che playStation
        gun.transform.localPosition+=(originalP-gun.transform.localPosition)*resistThrill*Time.deltaTime;
        if(rt>0f && SetUp.command){
             float t=(int)(pressLevels*rt);
             if(timeShoot>=mTimeShoot/t){
               timeShoot=0f; 
               GameObject o=Instantiate(sampleBullet,transform.position,transform.rotation);
               gun.transform.localPosition+=Vector3.forward*forceThrill*Time.deltaTime;
              
           }
           timeShoot+=Time.deltaTime;
        }else
            timeShoot=0;

        
       
    }
   
 
}
