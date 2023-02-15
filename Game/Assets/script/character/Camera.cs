using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Quaternion offset;
    private Gyroscope gyro;
    public float speedRotationG;
    public float speedRotationM;
    public float limitRotate;
    public enum typeMouve{mouse,gyro};
    public typeMouve typeMCamera;
    private enum position{sinistra,centro,destra}
    private position posCamera;
    private float rotationX = 0f;
    private float rotationY = 0f;
    public GameObject testaR;
    public float heightH;//altezza massima
    public float heightL;//altezza minima
    public GameObject body;
    public float dInclinate;
    public float MrotateX;
    public float MrotateZ;
     public UnityEngine.InputSystem.InputActionAsset controller;
    void Start()
    {
    //  controller.FindAction("Reset").started +=resetV; 
     // controller.FindAction("Mov_press").started +=Move_press; 
      if(typeMCamera==typeMouve.gyro){
          EnableGyro();
          offset = transform.rotation * Quaternion.Inverse(new Quaternion(Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w));
      }
    }
    private bool EnableGyro(){
       if(SystemInfo.supportsGyroscope){
            Input.gyro.updateInterval = 0.1f;
            gyro=Input.gyro;
            gyro.enabled=true;
            return true;
       }
       return false;
    }
    private void angle(){
        if(typeMCamera==typeMouve.gyro){
          
                float x=Mathf.Clamp(Input.gyro.rotationRate.x,-limitRotate,limitRotate);
                float y=Mathf.Clamp(Input.gyro.rotationRate.y,-limitRotate,limitRotate);
                float z=Mathf.Clamp(Input.gyro.rotationRate.z,-limitRotate,limitRotate)*0.5f;
                testaR.transform.localEulerAngles+=new Vector3(-x,0,z)*speedRotationG;
            //   camera.transform.Rotate(-Input.gyro.rotationRateUnbiased.x*speedRotation,0, Input.gyro.rotationRateUnbiased.z*speedRotation);
                body.transform.Rotate(0, -y*speedRotationG,0);
        }else if(typeMCamera==typeMouve.mouse){
      
                rotationY = Input.GetAxis("Mouse X") * speedRotationM;
                rotationX = Input.GetAxis("Mouse Y") * speedRotationM;
                testaR.transform.localEulerAngles += new Vector3(-rotationX,0,0); 
                body.transform.Rotate(0, rotationY*speedRotationM,0);
              //  body.GetComponent<CharacterController>().Rotate(0, rotationY*speedRotationM,0);
        }
        if(testaR.transform.localEulerAngles.x>180 && testaR.transform.localEulerAngles.x<(360-MrotateX)){
            testaR.transform.localEulerAngles+=Vector3.right*((360-MrotateX)-testaR.transform.localEulerAngles.x);
        }
        if(testaR.transform.localEulerAngles.x<180 && testaR.transform.localEulerAngles.x>MrotateX){
            testaR.transform.localEulerAngles+=Vector3.right*(MrotateX-testaR.transform.localEulerAngles.x);
        }
      
        if(testaR.transform.localEulerAngles.z>180 && testaR.transform.localEulerAngles.z<(360-MrotateZ)){
            testaR.transform.localEulerAngles+=Vector3.forward*((360-MrotateZ)-testaR.transform.localEulerAngles.z);
        }
        if(testaR.transform.localEulerAngles.z<180 && testaR.transform.localEulerAngles.z>MrotateZ){
            testaR.transform.localEulerAngles+=Vector3.forward*(MrotateZ-testaR.transform.localEulerAngles.z);
        }
       
    }
    void resetV(){
            testaR.transform.localEulerAngles=new Vector3(0,0,0);
            
    }
    void up_down(){
          if(transform.localPosition.y>=heightH )
                transform.localPosition-=Vector3.up*(heightH-heightL);
          else if(transform.localPosition.y<=heightL)
                transform.localPosition+=Vector3.up*(heightH-heightL); 
    }
    void Dir_ori(){
       
    }
    private void Update(){
        angle();
        float Dir=Input.GetAxis("d_pad_x");
      
        if(Input.GetButtonDown("y")){
            resetV();
        }
         if(Input.GetButtonDown("stick_right_press")){
            up_down();
        }
        if(Dir==1 && transform.localPosition.x==0){
            posCamera=position.destra;
            transform.localPosition+=Vector3.right*(dInclinate); 
        }else if(Dir==-1 && transform.localPosition.x==0){
            posCamera=position.sinistra;
            transform.localPosition-=Vector3.right*(dInclinate); 
        }else if(Dir==0){
           posCamera=position.centro;
            transform.localPosition-=Vector3.right*(transform.localPosition.x); 
        }
    }
}
