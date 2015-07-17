using UnityEngine;
using System.Collections;

public class KyelMove : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = new Vector3 (speed, 0, 0);

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			transform.position = new Vector3 (-13.976f, -0.3090908f, 2.739f);
			print(transform.position.x);
			rb.velocity = new Vector3 (0, 0, 0);
		}
	}
}
