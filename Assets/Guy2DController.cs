using UnityEngine;
using System.Collections;

public class Guy2DController : MonoBehaviour {

	float Speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.D))
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (Speed, 0, 0));

		if (Input.GetKey (KeyCode.A))
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (-Speed, 0, 0));

		if (Input.GetKey (KeyCode.W))
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, Speed, 0));

		if (Input.GetKey (KeyCode.S))
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, -Speed, 0));
		
}
}