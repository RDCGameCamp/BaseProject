using UnityEngine;
using System.Collections;

public class FirstKeyPickup : MonoBehaviour {
	public GameObject firstdoor;
	public void OnTriggerEnter(Collider other) {


		firstdoor.transform.position = new Vector3 (14.45f, 6.84f, -1.343f);

		Destroy (gameObject);
	}
}
