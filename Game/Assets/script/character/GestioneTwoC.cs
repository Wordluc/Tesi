using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.InputSystem;
public class GestioneTwoC : MonoBehaviour
{
    public UnityEngine.Camera Dx;
    public UnityEngine.Camera Sx;
    public enum occhioPigro{destro,sinistro,sano};
    public enum pigroGrandezza{grande,piccolo}
    public pigroGrandezza occhioDiff;
    public occhioPigro oPigro;
    public int dOcchi;
    public InputActionAsset controller;
    void Start()
    { 
      controller.FindAction("CambioO").started +=changePigro;    
      Dx.transform.localPosition =new Vector3(dOcchi,0,0);
      Sx.transform.localPosition =new Vector3(-dOcchi,0,0);
      occhioDiff=pigroGrandezza.grande;
      changePigro(oPigro);
      
    }
    public void changePigro(UnityEngine.InputSystem.InputAction.CallbackContext context){
      if(oPigro==occhioPigro.destro){
            changePigro(occhioPigro.sinistro);
      }else if(oPigro==occhioPigro.sinistro){
            changePigro(occhioPigro.sano);
      }else if(oPigro==occhioPigro.sano){
            changePigro(occhioPigro.destro);
      }
    }
    private void setGP(UnityEngine.Camera cP,UnityEngine.Camera cS){
            //Cp occhio pigro->visualizza tutto
            //cS visualizza in parte
            cP.cullingMask=-1;
            if(occhioDiff==pigroGrandezza.grande)
              cS.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
            else if(occhioDiff==pigroGrandezza.piccolo){
              cS.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroG"));
              cS.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioPigroP"));
            }
    }
    public void changePigro(occhioPigro goal){
      //&=  ~(1 <<   ->visualizza tutto tranne...
      if(goal==occhioPigro.destro){
            oPigro=occhioPigro.destro;
            setGP(Dx,Sx);
      }else if(goal==occhioPigro.sinistro){
            oPigro=occhioPigro.sinistro;
            setGP(Sx,Dx);
           
      }else if(goal==occhioPigro.sano){
              oPigro=occhioPigro.sano;
              Sx.cullingMask=-1;
              Dx.cullingMask=-1;
      }

    }
}
