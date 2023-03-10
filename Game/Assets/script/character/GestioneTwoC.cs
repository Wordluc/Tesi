using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GestioneTwoC : MonoBehaviour
{
    public UnityEngine.Camera Dx;
    public UnityEngine.Camera Sx;
    public  enum occhioPigro{destro,sinistro,sano};
    public static occhioPigro oPigro;
    public int dOcchi;
    public float angle;
   
    private void setGP(UnityEngine.Camera cP,UnityEngine.Camera cS){
            //Cp occhio pigro->visualizza tutto
            //cS visualizza in parte
            cP.cullingMask=-1;
            cS.cullingMask=-1;
            cS.cullingMask&=  ~(1 << LayerMask.NameToLayer("OcchioMalato"));
           
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
    private void Update() {
      Dx.transform.localPosition =new Vector3(dOcchi,0,0);
      Sx.transform.localPosition =new Vector3(-dOcchi,0,0);

      Dx.transform.localEulerAngles=Vector3.up*angle;
      Sx.transform.localEulerAngles=-Vector3.up*angle;

      if(Input.GetButtonDown("b") && SetUp.getCommand()){
         if(oPigro==occhioPigro.destro)
            oPigro=occhioPigro.sinistro;
         else if(oPigro==occhioPigro.sinistro)
             oPigro=occhioPigro.sano;
         else if(oPigro==occhioPigro.sano)
             oPigro=occhioPigro.destro;  
      }
      changePigro(oPigro);
    }
}
