using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public float force;
    public float timeM;
    private float time;
    void Start()
    
    {
              GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward)*force);
    }
    void Update()
    {
       transform.Translate(Vector3.forward*speed*Time.deltaTime);
       time+=Time.deltaTime;
       if(time>=timeM){
        time=0;
          Destroy(gameObject);
       }

    }
     void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);
       
    }
}
