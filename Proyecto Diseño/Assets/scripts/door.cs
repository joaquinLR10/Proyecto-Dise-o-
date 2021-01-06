using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : VoiceInteractable
{
      
     
       bool respuesta=false;
       public override void VoiceInteract(string action)
       {
        if(action=="open")
        {
          Debug.Log("lo hemos logrado");
        }
       

       }
       

     
}
