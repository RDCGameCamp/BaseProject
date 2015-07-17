using UnityEngine;
using System.Collections;

public class BlockDestroy : MonoBehaviour {

	public void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
	}
}
