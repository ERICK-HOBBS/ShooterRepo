using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyScript : MonoBehaviour
{

    public int EnemyHealth = 10;
    public GameObject TheZombie;

    void DeductPoints(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            GetComponent<ZombieFollow>().enabled = false;
            TheZombie.GetComponent<Animation>().Play("Dying");
            StartCoroutine(KillZombie());
        }
    }

    IEnumerator KillZombie()
    
        {
            yield return new WaitForSeconds(3);
            TheZombie.SetActive(false);
        }
    
}



