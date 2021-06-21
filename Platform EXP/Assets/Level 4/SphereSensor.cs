using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSensor : MonoBehaviour
{
    public Animator LightAnimator1;
    public Animator LightAnimator2;
    public Animator LightAnimator3;
    public Animator LightAnimator4;
    public Animator LightAnimator5;
    public Animator LightAnimator6;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Balls"))
        {
            LightAnimator1.SetBool("BLights", true);
            print("BLights...");

            LightAnimator2.SetBool("BLights", true);
            print("Blights...");

            LightAnimator3.SetBool("BLights", true);
            print("BLights...");

            LightAnimator4.SetBool("BLights", true);
            print("BLights...");

            LightAnimator5.SetBool("BLights", true);
            print("BLights...");

            LightAnimator6.SetBool("BLights", true);
            print("BLights...");
        }

    }

    
}
