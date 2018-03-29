using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;


    void Awake ()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
	}

    public void Collect(int passedValue, GameObject passedObject)
    {
    passedObject.GetComponent<Renderer>().enabled = false;
        Destroy (passedObject, 1.0f);   
    
    }
  
}
