using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {

			rb.velocity = new Vector3(-speed, 0, 0);
		
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("trigger"))
		{
			transform.position = new Vector3(10.65f, 2.467f, -4.32f);
			print(transform.position.x);
		}
}
}