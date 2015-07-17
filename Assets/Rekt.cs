using UnityEngine;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.Examples {
	
	public class Rekt : MonoBehaviour {
		public GameObject player;
		public string message;
		
		public void OnTriggerEnter(Collider other) {
			if (other.gameObject.CompareTag ("Player")) {
				DialogueManager.ShowAlert ("Git Rekt");
				Sequencer.Message (message);

			}

		}
		
	}
	
}
