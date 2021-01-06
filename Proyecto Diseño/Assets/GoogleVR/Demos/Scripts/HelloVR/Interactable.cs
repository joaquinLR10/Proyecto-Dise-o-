

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : VoiceInteractable
{
    bool isInsideZone = false;
    bool action=false;

    public virtual void Interact(string action)
    {
        VoiceInteract(action);
    }
      public override void VoiceInteract(string action)
       {
          
        if(action=="open")
        {
        Destroy(gameObject);
        }
       

       }

    void Update(string action)
    {
       // Input.GetKeyDown(KeyCode.I)
        if(isInsideZone)
        {
           Interact(action);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        isInsideZone = false;
    }
}
