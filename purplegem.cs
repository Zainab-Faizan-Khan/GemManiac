using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPurple : MonoBehaviour
{
  
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        Score.currentScore += 5000;
             
       
        collectSound.Play();
        Destroy(gameObject);
    }
    
}
