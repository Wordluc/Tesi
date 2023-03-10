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
    public float g;
     public InputActionAsset controller;
    void Start()
    {
      ball.SetActive(false);
       // controller.FindAction("Tel_press").started +=tel;      
    }
    private void moveBall(){
  
        float x=Input.GetAxis("stick_left_x");
        float y=Input.GetAxis("stick_left_y");
        if((Mathf.Abs(x)>=0.1f || Mathf.Abs(y)>=0.1f)){
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
           v=new Vector3(x,-g,-y)*speed*Time.deltaTime;
           v=o.transform.TransformDirection(v);
           ball.GetComponent<CharacterController>().Move(v);
        }
        else{
           Destroy(o);
           ball.SetActive(false);
           ball.GetComponent<CharacterController>().enabled = false;
           ball.transform.localPosition=new Vector3(0,0,0f);
        }
        if(Input.GetButtonDown("stick_left_press"))
           tel();
    }
    void tel(){
          
            GetComponent<CharacterController>().enabled = false;
            transform.position=new Vector3(ball.transform.position.x,ball.transform.position.y+hteleport,ball.transform.position.z);
            GetComponent<CharacterController>().enabled = true;
    }
    void Update()
    { 
        if(SetUp.getCommand())
           moveBall();
    }
}
