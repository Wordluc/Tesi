using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp : MonoBehaviour
{
    public float g;
    void Start()
    {
        if(Input.anyKeyDown)
           Debug.Log(Input.inputString);
        Physics.gravity = new Vector3(0, -g, 0);
    }

}
