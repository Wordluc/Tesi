using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class portal : MonoBehaviour
{
    public GameObject rocks;
    public bool state;
    public float speed;
    public float goalScore;
    public string newScena;
    void Start() {
          GetComponent<Renderer>().enabled=false;
          rocks.SetActive(false);
    } 
    private void open(){
            rocks.SetActive(true);
            GetComponent<Renderer>().enabled=true;
            state=true;
    }
    void Update() {
        if(SetUp.score>=goalScore)
           open();
         if(state){
            rocks.transform.Rotate(0,0,Time.deltaTime*speed);
         }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Character" && state){
            SceneManager.LoadScene(newScena);
        }
    }
}
