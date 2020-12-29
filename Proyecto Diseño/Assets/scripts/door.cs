using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : VoiceInteractable
{

  
  

   

    public override void VoiceInteract(string action)
       {
          
        if(action=="open")
        {
        Destroy(gameObject);
        }
       

       }
      
       
        
    }