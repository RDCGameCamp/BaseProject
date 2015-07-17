using UnityEngine;
using System.Collections;

public class brekreturn : MonoBehaviour {
	public GameObject brek;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("brek")) 
		{
			brek.transform.position = new Vector3 (26.81f, 3.265f, -0.3232789f);
			print (transform.position.x);
		}
	}
}
