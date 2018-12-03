using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleAmmoPickUp : MonoBehaviour
{
    public AudioSource AmmoSound;

    void OnTriggerEnter(Collider other)
    {
        AmmoSound.Play();

        if (GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 30;
            gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 30;
            gameObject.SetActive(false);
        }
    }
}
