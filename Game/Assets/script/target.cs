using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public int p;
    public GameObject score_fly;
    public float size_text;
    void Update()
    {
       
    }
    public void hit(){
          SetUp.score+=p;  
          GameObject a=Instantiate(score_fly);
          a.transform.position=transform.position;
          a.GetComponent<fly_score>().go(p+"",size_text*transform.localScale.magnitude);
          
    }
}
