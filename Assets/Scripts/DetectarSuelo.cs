using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarSuelo : MonoBehaviour
{
   public static bool TocarSuelo;
   
   private GameObject BarraDeSalud;


    void Start (){
        BarraDeSalud = GameObject.Find("BarraSalud");
    }

   private void OnTriggerEnter2D(Collider2D colision)
   {
       TocarSuelo= true;
       if (colision.gameObject.tag == "Spikes"){
            
           BarraDeSalud.SendMessage("BajarSalud",10);
        }
   }

    private void OnTriggerExit2D(Collider2D colision)
   {
       TocarSuelo= false;
   }


   
}
