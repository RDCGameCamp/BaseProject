using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public bool rendering;
	GameObject fireObject;
	
	void Start () {
		rendering = false;
		fireObject = gameObject;
		gameObject.GetComponent<ParticleSystem>().enableEmission = false;
	}
	
	void OnTriggerEnter (Collider collider) {
		//if (collider.gameObject.tag == "Player") {
			rendering = true;
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
		//}
	}

	void OnTriggerExit (Collider collider){
		//if (collider.gameObject.tag == "Player") {
			rendering = true;
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
		//}
	}

	void FixedUpdate(){
		//if(Input.GetKeyDown(KeyCode.Q))
		//{
		//	gameObject.GetComponent<ParticleSystem>().enableEmission = true;;
		//	rendering = true;
		//}
	}
}	