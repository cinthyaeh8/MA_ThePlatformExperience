using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSensor : MonoBehaviour
{
    public Animator MusicAnimator1;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MusicAnimator1.SetBool("Reproduc1", true);
            print("Reproduc1...");

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MusicAnimator1.SetBool("Reproduc1", false);
            print("Reproduc1...");

        }

    }
}
