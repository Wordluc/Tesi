using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Option
{
    public GameObject back;
    public action a;
    void Start()
    {
        
    }
    void Update()
    {
        if(status){
           back.SetActive(true);
           if(Input.GetButtonDown("x"))
              a.go();
        }else 
           back.SetActive(false);
           
    }
}
