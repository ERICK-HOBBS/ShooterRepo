using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor001 : MonoBehaviour
{
    public GameObject TextDisplay;
    public float TheDistance = PlayerCasting.DistanceFromTarget;

    public GameObject TheDoor;
    public AudioSource DoorSFX;
    private bool DoorOpen = false;
    public GameObject ObjectiveComplete;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
        

    }
    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Open!";
        }

        if (Input.GetButtonDown("Action") && DoorOpen == false)
        {
            if (TheDistance <= 2)
            {
                DoorOpen = true;
                StartCoroutine("OpenTheDoor");
                ObjectiveComplete.SetActive(true);

            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor()
    {
        TheDoor.GetComponent<Animator>().enabled = true;
        DoorSFX.Play();
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5);
        TheDoor.GetComponent<Animator>().enabled = true;
        DoorSFX.Play();
        yield return new WaitForSeconds(1);
        TheDoor.GetComponent<Animator>().enabled = false;
        DoorOpen = false;
    }
}