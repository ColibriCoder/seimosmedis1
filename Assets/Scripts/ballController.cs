using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ballController : MonoBehaviour {
    public float movementSpeed = 0.03f;
    public float rotationSpeed = 100.0f;
    public Transform spawnPoint;
    private int coinsCollected;
    public float score = 100;
    public Text gui;


    // Use this for initialization
  
    void Start() {
        // spawnPoint = spawnPointObject.position;
        coinsCollected = 3;
        score = 100;
        gui.text = score.ToString();
        

    }

    // Update is called once per frame
    void FixedUpdate() {
        float h = rotationSpeed * Input.GetAxis("Mouse X");
        //float v = speed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
        transform.Translate(Input.GetAxis("Horizontal") * movementSpeed, 0f, Input.GetAxis("Vertical") * movementSpeed);
    }

    void Update()
    {
        score -= 1 * Time.deltaTime;
        gui.text = score.ToString();
        if (score <= 0)
            Destroy(gameObject);

        //this.transform.rotat
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("platform"))
        {
          
            other.GetComponent<AudioSource>().Play();
            coinsCollected = 0;
        }
            

        if (other.CompareTag("respawn"))
            transform.position = spawnPoint.position;

        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            coinsCollected++;
            Debug.Log(coinsCollected);
        }
        if (other.CompareTag("Cube"))
        {
            score+=5;
            
        }
        if (other.CompareTag("Enemy"))
        {
            score -= 200;

        }
        if (other.CompareTag("lastPlatform"))
        {
            //if (coinsCollected != 3)
                transform.position = spawnPoint.position;

        }
        //pidedam komientara

        // transform.position = spawnPoint.position;
        /*
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            audioSource.Play();
            */
    }
    
    void OnTriggerExit(Collider other)
    {
        
    }
    
}
