using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject scelta;
    
    void Update()
    {   
        
        if(Input.GetButtonDown("option_right")){
               scelta.SetActive(true);
        }

    }
}
