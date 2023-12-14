using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public float health = 20f;
  
    public void TakeDamage(float amount) {
      
        health -= amount;
     
        if(health <= 0f)
        {
            die();
        }


    }

    void die()
    {
        Destroy(gameObject);
    }



}