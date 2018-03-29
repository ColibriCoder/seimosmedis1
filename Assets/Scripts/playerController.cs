using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	private Rigidbody rigidbody = null;
	// Use this for initialization
	void Start () {
		//rigidbody = GetComponent<Rigidbody>();
	}
	
	void Update() {
		//transform.rotation = Camera.main.transform.rotation;
	}
	// Update is called once per frame
	void FixedUpdate () {
		//rigidbody.velocity = transform.forward;
		//transform.position +=  Camera.main.transform.forward * 100f;
		//transform.Translate(0f, -0.1f, 0);
		transform.position += Camera.main.transform.forward * 0.05F;
		//transform.Translate(0f, -0.1f, 5f * 0.015f);
		//rigidbody.velocity = trasform.forward + -trasform.up;
			
	}
}
