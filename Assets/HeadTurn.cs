using UnityEngine;
using System.Collections;

public class HeadTurn : MonoBehaviour {

	// Use this for initialization
	void Update () {
		transform.Rotate (new Vector3 (5,  5, 20 ) * Time.deltaTime);
	
	}

}
