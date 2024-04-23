using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTrigger : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip collect;
    public float volume;

    public bool isTalking = true;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isTalking)
            {
                //aSource.Play();
                aSource.PlayOneShot(collect, volume);
                isTalking = false;

            }
           
        }
       
    }
}
