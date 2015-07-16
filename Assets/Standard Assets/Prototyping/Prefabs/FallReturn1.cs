using UnityEngine;
using System.Collections;

public class FallReturn1 : MonoBehaviour {
	public GameObject player;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			player.transform.position = new Vector3(1.52f, 30.82f, -26.36f);
			print(transform.position.x);
		}
}
}