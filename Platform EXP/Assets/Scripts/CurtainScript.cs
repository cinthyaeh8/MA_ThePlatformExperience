using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainScript : MonoBehaviour
{
    public Animator myAnimationController;

    private void OnTrigerEnter(Collider other)
    {
        if (other.CompareTag('Player'))
        {
            myAnimationController.SetBool("Curtain Anim", true);
            print("openCurtain Anim");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag('Player'))
        {
            myAnimationController.SetBool("Curtain Anim", false);
            print("closeCurtain Anim");
        }
    }
   
}
   