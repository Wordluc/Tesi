using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject scelta;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetButtonDown("b")){
            scelta.SetActive(true);
           
        }
    }
}
