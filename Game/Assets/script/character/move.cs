using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public CharacterController body;
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {    
          
           Vector3 move=new Vector3(Input.GetAxis("stick_right_x"),-1,-Input.GetAxis("stick_right_y"))*Time.deltaTime;
           
           move = this.transform.TransformDirection(move);
           if( SetUp.command){
              body.Move(move*speed);
        
           }
           
    }
}
