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
       // controller.FindAction("Tel_press").started +=tel;      
    }
    private void moveBall(){
  
        float x=Input.GetAxis("stick_left_x");
        float y=Input.GetAxis("stick_left_y");
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
        if(Input.GetButtonDown("stick_left_press"))
           tel();
    }
    void tel(){
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
