using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public Menu Menu;
 
    public slide []set_Settings;
    public int i_vector;
    private float pre_t;
   // public LevelAmbliopia lev;
    void Start()
    {
        set_Settings[0].status=true;
        //lev.status=false;
    }
    int slide(int iV,int size,float t){
        while(t!=0){
            if(t==1){
                iV+=1;
                t-=1;
               
                if(iV==size)
                  iV=0;
                
            }else if(t==-1){
                iV-=1;
                t+=1;
                if(iV<0)
                  iV=size-1; 
            }
             Debug.Log(iV+","+t);
            }
        return iV;
    }
    void Update()
    {
        if(Input.GetAxis("d_pad_y")!=pre_t){
            int a=slide(i_vector,set_Settings.Length,-Input.GetAxis("d_pad_y"));
            set_Settings[i_vector].status=(false);
            i_vector=a;
            set_Settings[i_vector].status=(true);
        }
        pre_t=Input.GetAxis("d_pad_y");
           // Debug.Log(a);

      
        if(Input.GetButtonDown("b")){
            Menu.finestre=Menu.stati.menu;
           
        }
        if(Input.GetButtonDown("option_right")){
           Menu.finestre=Menu.stati.close;
        }
    }
}
