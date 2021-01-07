using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
   public AudioClip sonido = null;
   public float volumen = 1.0f;//indica el volumen del sonido 
   protected Transform posicion = null;
   
    public void Start()
    {
        posicion= transform;
    }

   
   
   public void update(){
    if(CompareTag("elsinhueso"))
        {
       if(sonido)
       AudioSource.PlayClipAtPoint(sonido,posicion.position,volumen);
       Debug.Log("cogiendo jamon....");
        }
        else
        {
       if(sonido)
       AudioSource.PlayClipAtPoint(sonido,posicion.position,volumen);
       Debug.Log("cogiendo posion......");
         
        }
       
    }
      
       
        
    }