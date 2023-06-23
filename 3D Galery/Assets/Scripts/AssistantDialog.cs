using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistantDialog : MonoBehaviour
{
   
   
    public AudioSource dialog;


    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!dialog.isPlaying)
            {
                dialog.Play();
            }
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            dialog.Stop();
            
        }
    }
}
