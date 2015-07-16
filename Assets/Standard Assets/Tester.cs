using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		
		var texture1 : Texture2D;
		var isTriggered = false;
		
		
		function OnTriggerEnter (col : Collider) {
			
			Debug.Log("triggering");
			isTriggered = true;
			
		}
		
		function OnTriggerExit (col : Collider) {
			
			Debug.Log("triggering exit");
			//isTriggered = false; I used this to change it back on exit as it suited my game
			
		}
		
		function Update () {
			
			if(isTriggered)
			{
				rend = gameObject.GetComponent(Renderer);
				rend.material.mainTexture = texture1;
				
			}
		}
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
