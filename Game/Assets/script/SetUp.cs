using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetUp : MonoBehaviour
{
    public TextMeshPro text;
    public static int score;
    public float g;
    public float t;
    public static float trasparency;
    static private bool command=true;
    public  bool Setcommand;
    public bool trasparency_variable;
    
    public static void setCommand(string who,bool value){
        command=value;
        Debug.Log(who+":"+value);
    }
     public static bool getCommand(){
        
        return command;
    }
    private void makeTransparentO(){
        GameObject []a=GameObject.FindGameObjectsWithTag("OcchioMalato");
        foreach(GameObject o in a){
           GameObject sano=Instantiate(o);
           Destroy(sano.GetComponent<Rigidbody>());//creo l'oggetto e disattivo rigidbody
           Collider[] colliders = sano.GetComponents<Collider>();
            // Disattiva tutti i Collider
            foreach (Collider collider in colliders)
            {
                collider.enabled = false;
            }
           sano.layer=0;
           sano.tag="new";//imposto il layer di default e cambio tag
           sano.layer=7;
           Material m=Resources.Load<Material>("s"+o.GetComponent<Renderer>().material.name.Replace(" (Instance)",""));//carico il materiale presente in resurces
           Color c=m.color;
           c.a = trasparency/100;//rendo il materiale trasparente
           m.color=c;
           sano.GetComponent<Renderer>().material=m;
           sano.transform.SetParent(o.transform);//settto l'oggetto creato come figlio
           sano.transform.localPosition=Vector3.zero;
            sano.transform.localEulerAngles=Vector3.zero;
           sano.transform.localScale=new Vector3(1,1,1);
       }
    }
    void Start()
    {
        SetUp.trasparency=t;
        SetUp.score=0;
        command=Setcommand;
        makeTransparentO();
        Physics.gravity = new Vector3(0, -g, 0);
       
    }
    void changeTransparent(){//adeguo la trasparenza a tutti gli oggetti con tag new 
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
        changeTransparent();
        if(t!=SetUp.trasparency && trasparency_variable)
            SetUp.trasparency=t;
        if(text!=null)
          text.text="Score:"+SetUp.score;
    }
}
