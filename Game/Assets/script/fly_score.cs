using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class fly_score : MonoBehaviour
{
    public  float speed_up;
    public float speed_reduce;
    public float noise;
    private float t_actual;
    public void go(string score,float size_text)
    {
        GetComponent<TextMeshPro>().text=score;
        GetComponent<TextMeshPro>().transform.localScale=Vector3.one*size_text;
         
    }

    void Update()
    {
        transform.position+=new Vector3(Mathf.Sin(t_actual*Mathf.PI)*noise,speed_up,0)*Time.deltaTime;
        if(  GetComponent<TextMeshPro>().enabled==true)
           transform.localScale-=new Vector3(1,1,1)*speed_reduce*Time.deltaTime;
        if(transform.localScale.x<=0 || t_actual>=10 )
           Destroy(gameObject);
        t_actual+=Time.deltaTime;
    }
      void OnTriggerExit(Collider other)
    {
         GetComponent<TextMeshPro>().enabled =true;
    }
         void OnTriggerStay(Collider other)
    {
          GetComponent<TextMeshPro>().enabled =true;
    }
  
}
