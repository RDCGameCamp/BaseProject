using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {

		rb.velocity = new Vector3 (10, 0, 0);
		
	}
}