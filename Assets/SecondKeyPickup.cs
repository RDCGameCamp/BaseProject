using UnityEngine;
using System.Collections;

public class SecondKeyPickup : MonoBehaviour {
	public GameObject seconddoor;
	public void OnTriggerEnter(Collider other) {
		seconddoor.transform.position = new Vector3 (35.06f, 6.84f, -2.55f);
		print (transform.position.x);
		Destroy (gameObject);
	}
}
