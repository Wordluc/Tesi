using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class move : MonoBehaviour
{
    public CharacterController body;
    public InputActionAsset controller;
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {    
           Vector2 vMove=controller.FindAction("Move").ReadValue<Vector2>();
           Vector3 move=new Vector3(vMove[0],-1,vMove[1]);
           move = this.transform.TransformDirection(move);
           
           body.Move(move*speed);
           
    }
}
