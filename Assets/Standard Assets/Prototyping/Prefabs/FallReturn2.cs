using UnityEngine;
using System.Collections;

public class FallReturn2 : MonoBehaviour {
	public GameObject player;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			player.transform.position = new Vector3(25.2f, 3.21f, 12.66f);
			print(transform.position.x);
		}
	}
}