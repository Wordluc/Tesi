using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class action : MonoBehaviour
{
    public enum type{close_open_W,quit,open_scene};
    public type a;
    public GameObject panel;
    public string scena;
    public void go(){
        switch(a){
            case type.close_open_W:
               if(panel.activeSelf)
                  panel.SetActive(false);
                else 
                  panel.SetActive(true);
            
               break;
            case type.quit:
               Application.Quit();
               break;   
            case type.open_scene:
               SceneManager.LoadScene(scena);
               break;
        }
    }

}
