using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class teleporter : MonoBehaviour
{
    public GameObject ball;
    public float speed;
    private GameObject o=null;
    public float hteleport;
     public InputActionAsset controller;
    void Start()
    {
        controller.FindAction("Tel_press").started +=tel;      
    }
    private void moveBall(){
        Vector2 c=controller.FindAction("Tel").ReadValue<Vector2>();
        float x=c[0];
        float y=-c[1];
        if(Mathf.Abs(x)>=0.1f || Mathf.Abs(y)>=0.1f){
           ball.SetActive(true);
          
           if(!ball.GetComponent<CharacterController>().enabled){
               Vector3 angle;
               ball.transform.localEulerAngles=transform.localEulerAngles;
               angle=transform.localEulerAngles;
               o=Instantiate(ball);
               o.SetActive(false);
               o.transform.localEulerAngles=angle;
           
           }
           ball.GetComponent<CharacterController>().enabled = true;
           Vector3 v;
           v=new Vector3(x,-2f,-y)*speed;
           v=o.transform.TransformDirection(v);
           ball.GetComponent<CharacterController>().Move(v);
        }
        else{
           Destroy(o);
           ball.GetComponent<CharacterController>().enabled = false;
           ball.transform.localPosition=new Vector3(0,0,3f);
        }
    }
    void tel(UnityEngine.InputSystem.InputAction.CallbackContext context){
            Debug.Log(ball.transform.position);
            GetComponent<CharacterController>().enabled = false;
            transform.position=new Vector3(ball.transform.position.x,ball.transform.position.y+hteleport,ball.transform.position.z);
            GetComponent<CharacterController>().enabled = true;
    }
    void Update()
    { 
         
        moveBall();
    }
}
