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
        controller.FindAction("RT").performed+=shootOn;      
    }
    void shootOn(UnityEngine.InputSystem.InputAction.CallbackContext context){
           if(timeShoot>=mTimeShoot){
               timeShoot=0f; 
               GameObject o=Instantiate(sampleBullet,transform.position,transform.rotation);
              
           }
          
        }
    void Update()
    {
        timeShoot+=Time.deltaTime;
    }
   
 
}
