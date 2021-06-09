using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorScript : MonoBehaviour
{
    public Animator myAnimationController1;
    public Animator myAnimationController2;
    public Animator myAnimationController3;
    public Animator myAnimationController4;
    public Animator LightAnimator1;
    public Animator LightAnimator2;
    public Animator LightAnimator3;
    public Animator LightAnimator4;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController1.SetBool("Curtain01", true);
            print("Curtain01...");

            myAnimationController2.SetBool("Curtain02", true);
            print("Curtain02...");

            myAnimationController3.SetBool("Curtain03", true);
            print("Curtain03...");

            myAnimationController4.SetBool("Curtain04", true);
            print("Curtain...");

            LightAnimator1.SetBool("ALight", true);
            print("ALight...");

            LightAnimator2.SetBool("ALight", true);
            print("Alight...");

            LightAnimator3.SetBool("ALight", true);
            print("ALight...");

            LightAnimator4.SetBool("ALight", true);
            print("ALight...");
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController1.SetBool("Curtain01", false);
            print("Curtain01...");

            myAnimationController2.SetBool("Curtain02", false);
            print("Curtain02...");

            myAnimationController3.SetBool("Curtain03", false);
            print("Curtain03...");

            myAnimationController4.SetBool("Curtain04", false);
            print("Curtain04...");


            LightAnimator1.SetBool("ALight", false);
            print("ALight...");

            LightAnimator2.SetBool("ALight", false);
            print("Alight...");

            LightAnimator3.SetBool("ALight", false);
            print("ALight...");

            LightAnimator4.SetBool("ALight", false);
            print("ALight...");
        }
        
    }
}
