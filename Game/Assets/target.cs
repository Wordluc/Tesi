using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class target : MonoBehaviour
{
    public int p;

    void Update()
    {
    }
    public void hit(){
        Debug.Log("Raycast hit this object!");
          SetUp.score+=p;  
    }
}
