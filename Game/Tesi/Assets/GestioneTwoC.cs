using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GestioneTwoC : MonoBehaviour
{
    public UnityEngine.Camera Dx;
    public UnityEngine.Camera Sx;
    public enum occhioPigro{destro,sinistro,sano};
    public enum pigroGrandezza{grande,piccolo}
    public pigroGrandezza occhioDiff;
    public occhioPigro oPigro=occhioPigro.sano;
    public int dOcchi;
 
    void Start()
    { 
         
      Dx.transform.localPosition =new Vector3(dOcchi,0,0);
      Sx.transform.localPosition =new Vector3(-dOcchi,0,0);
      occhioDiff=pigroGrandezza.grande;
     changePigro();
      
    }
    public void changePigro(){
      if(oPigro==occhioPigro.destro){
            changePigro(occhioPigro.sinistro);
      }else if(oPigro==occhioPigro.sinistro){
            changePigro(occhioPigro.sano);
      }else if(oPigro==occhioPigro.sano){
            changePigro(occhioPigro.destro);
      }
    }
    public void changePigro(occhioPigro goal){
      //&=  ~(1 <<   ->visualizza tutto tranne...
      if(goal==occhioPigro.destro){
            oPigro=occhioPigro.destro;
            Dx.cullingMask=-1;
            if(occhioDiff==pigroGrandezza.grande)
              Sx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
            else if(occhioDiff==pigroGrandezza.piccolo){
              Sx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
              Sx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroP"));
            }
      }else if(goal==occhioPigro.sinistro){
            oPigro=occhioPigro.sinistro;
            Sx.cullingMask=-1;
            if(occhioDiff==pigroGrandezza.grande)
              Dx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
            else if(occhioDiff==pigroGrandezza.piccolo){
              Dx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
              Dx.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroP"));
            }
           
      }else if(goal==occhioPigro.sano){
              oPigro=occhioPigro.sano;
              Sx.cullingMask=-1;
              Dx.cullingMask=-1;
      }

    }

    void Update() {
   
      if(Input.GetButtonDown("X")){
        changePigro();
      }
    
            
            
      
    }
}
