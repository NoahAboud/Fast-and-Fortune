using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    private bool triggerMoney = true; 

    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.CompareTag("Building") && triggerMoney)
        {         
            collisionParticleSystem.Play();            
            triggerMoney = false;
           
            Invoke(nameof(StopParticleEffect), 1f);
        }
    }
  
    void StopParticleEffect()
    {
        collisionParticleSystem.Stop(); 
        triggerMoney = true; 
    }
}