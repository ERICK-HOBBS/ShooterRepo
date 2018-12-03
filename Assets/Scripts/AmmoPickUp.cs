using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public AudioSource AmmoSound;

    void OnTriggerEnter(Collider other)
    {
        AmmoSound.Play();

        if (GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 10;
            gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 10;
            gameObject.SetActive(false);
        }
    }
}
