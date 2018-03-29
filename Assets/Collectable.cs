using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

    public int value;
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

    }
    
    void OnTriggerEnter()
    {
        GameManager.instance.Collect(value, gameObject);

        AudioSource source = GetComponent<AudioSource>();
        source.Play();

    }
    
}
