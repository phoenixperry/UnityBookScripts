using UnityEngine;
using System.Collections;

public class ThrowerTrigger : MonoBehaviour {
	public GUITexture crosshair; 
	public GUIText textHints; 
	// Use this for initialization

	void OnTriggerEnter(Collider col) { 
		if(col.gameObject.tag == "Player"){ 
			CoconutThrower.canThrow = true; 
			//note CoconutThrower is static hence why we can get it so 
			//easily
			crosshair.enabled = true; 
			if(!CoconutWin.haveWon){
				textHints.SendMessage("ShowHint",
				"\n\n\n\n There's a power cell attached to this game,\n maybe I'll win it if I can knock down all the targets...");
}
		}
	}

	void OnTriggerExit(Collider col) { 
		if(col.gameObject.tag == "Player") { 
			CoconutThrower.canThrow = false; 
			crosshair.enabled = false; 
		}
	}
}
