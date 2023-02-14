using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody body;
    void Start()
    {
        
    }

    
    void Update()
    {
       
           
           body.transform.Translate(new Vector3(Input.GetAxis("M_ori"),0,-Input.GetAxis("M_ver")));
  
    }
}
