using UnityEngine;
using System.Collections;

public class FallReturn3 : MonoBehaviour {
	public GameObject player;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			player.transform.position = new Vector3(68f, 9f, 67f);
			print(transform.position.x);
		}
	}
}