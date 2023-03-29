using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public Option [] set_option;
    public int i_vector;
    private float pre_t;
    void Start()
    {
        set_option[0].status=true;
        for(int i=1;i<set_option.Length;i++)
           set_option[i].status=false;
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
            }
        return iV;
    }
    public void scroll(){
       if(Input.GetAxis("d_pad_y")!=pre_t){
            int a=slide(i_vector,set_option.Length,Input.GetAxis("d_pad_y"));
            set_option[i_vector].status=(false);
            i_vector=a;
            set_option[i_vector].status=(true);
        }
        pre_t=Input.GetAxis("d_pad_y");
    }
}
