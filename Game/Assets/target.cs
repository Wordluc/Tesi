using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class target : MonoBehaviour
{
    public TextMeshPro text;
    public int p;

    void Update()
    {
        text.text="Score:"+SetUp.score;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="bullet"){
            SetUp.score+=p;   
        }
    }
}
