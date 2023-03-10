using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shoot : MonoBehaviour
{
    public float mTimeShoot;
    public float timeShoot=0f;
     public string command;
     public GameObject gun;
     private Vector3 originalP;
     public float resistThrill;
     public float forceThrill;
     public float distant;
     private RaycastHit hit;
    void Start()
    {
       originalP=gun.transform.localPosition;
       
    }

     void FixedUpdate()
    {  
         
        float rt=Input.GetAxis(command);//in modo da poter usare sia controller xbox che playStation
        gun.transform.localPosition+=(originalP-gun.transform.localPosition)*resistThrill*Time.deltaTime;
        if(rt>0f && SetUp.getCommand()){
             if(timeShoot>=mTimeShoot){
                 timeShoot=0f; 
                 gun.transform.localPosition+=Vector3.forward*forceThrill*Time.deltaTime;
                 if (Physics.Raycast(transform.position, transform.forward, out hit, distant))
                 {
                    hit.collider.gameObject.SendMessage("hit", SendMessageOptions.DontRequireReceiver);
                    Debug.Log("Did Hit"+ hit.collider.gameObject.name);
                 }else
                 Debug.Log("NODid Hit"); 
           }
           timeShoot+=Time.deltaTime;
         
        }else
            timeShoot=0;

        
       
    }
   
 
}
