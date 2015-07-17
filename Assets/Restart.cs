using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public GameObject player;
	public void OnTriggerEnter(Collider other)
	{
		player.transform.position = new Vector3 (-120.53f, 0.5f, 0.03f);
		print (transform.position.x);
}
}