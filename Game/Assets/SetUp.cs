using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp : MonoBehaviour
{
    public float g;
    static public bool command;
    void Start()
    {
        Physics.gravity = new Vector3(0, -g, 0);
    }

}
