using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RifleFire : MonoBehaviour
{

    public GameObject theRifle;
    public AudioSource RifleSFX;
    public GameObject MuzzleFlash;
    public int AmmoCount;
    public int Firing;

    public GameObject UpCurs;
    public GameObject DownCurs;
    public GameObject LeftCurs;
    public GameObject RightCurs;


    void Update()
    {
        AmmoCount = GlobalAmmo.LoadedAmmo;

        if (Input.GetButtonDown("Fire1"))
        {
            if (AmmoCount >= 1)
            {
                if (Firing == 0)
                {              
                    StartCoroutine(Riflefire());
                }
            }
        }
    }

    public IEnumerator Riflefire()
    {

        Firing = 1;
        UpCurs.GetComponent<Animator>().enabled = true;
        DownCurs.GetComponent<Animator>().enabled = true;
        LeftCurs.GetComponent<Animator>().enabled = true;
        RightCurs.GetComponent<Animator>().enabled = true;
        GlobalAmmo.LoadedAmmo -= 1;
        RifleSFX.Play();
        MuzzleFlash.SetActive(true);
        theRifle.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
        theRifle.GetComponent<Animator>().enabled = false;
        UpCurs.GetComponent<Animator>().enabled = false;
        DownCurs.GetComponent<Animator>().enabled = false;
        LeftCurs.GetComponent<Animator>().enabled = false;
        RightCurs.GetComponent<Animator>().enabled = false;
        Firing = 0;
    }
}


