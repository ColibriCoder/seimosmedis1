using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{

    public GameObject light;
    private bool on = false;

    // Use this for initialization
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.tag == "Player" && !on)
        {
            light.SetActive(true);
            on = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        light.SetActive(false);
        on = false;
    }

}
