using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp : MonoBehaviour
{
    public static int score;
    public float g;
    public float trasparency;
    static public bool command;
    void Start()
    {
        Physics.gravity = new Vector3(0, -g, 0);
        GameObject []a=GameObject.FindGameObjectsWithTag("OcchioMalato");
       foreach(GameObject o in a){
           GameObject sano=Instantiate(o);
           sano.GetComponent<Rigidbody>().isKinematic = true;
           sano.layer=0;
           sano.tag="new";
           sano.transform.localScale=new Vector3(1,1,1);
           Material m=Resources.Load<Material>("s"+o.GetComponent<Renderer>().material.name.Replace(" (Instance)",""));
           Color c=m.color;
           c.a = trasparency;
           m.color=c;
           sano.GetComponent<Renderer>().material=m;
           sano.transform.SetParent(o.transform);
            sano.transform.localScale=new Vector3(1,1,1);
       }
    }
    void changeT(){
          GameObject []a=GameObject.FindGameObjectsWithTag("new");
       foreach(GameObject o in a){
         
           Material m=o.GetComponent<Renderer>().material;
           Color c=m.color;
           c.a = trasparency;
           m.color=c;
           o.GetComponent<Renderer>().material=m;
       }
    }
    void Update(){
        changeT();
    }
}
