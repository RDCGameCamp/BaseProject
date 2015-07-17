using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Rigidbody rb;
	public GameObject player;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		rb.velocity = new Vector3 (0, -4, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			player.transform.position = new Vector3 (22f, 0.5f, 0f);
			print (transform.position.x);
		}
	}
}
