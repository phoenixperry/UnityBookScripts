using UnityEngine;
using System.Collections;

public class PlayerCollisionRay : MonoBehaviour {
	GameObject currentDoor; 
	RaycastHit hit; 
	GUIText textHints; 
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast (transform.position, transform.forward, out hit, 3)){ 
			if(hit.collider.gameObject.tag == "playerDoor"){
				if(Inventory.charge == 4){
					currentDoor = hit.collider.gameObject; 
					currentDoor.SendMessage("DoorCheck"); 
				}
				// else if(Inventory.charge > 0 && Inventory.charge< 4){ 
				// 	//textHints.SendMessage("ShowHint", "this door won't budge wihtout 4 charges"); 
				// 	//transform.FindChild("door").audio.PlayOneShot(lockedSound); 

				// }
				// else{ 
				// //	transform.FindChild("door").audio.PlayOneShot(lockedSound); 
				// //	col.gameObject.SendMessage("HUDon"); 
				// //	textHints.SendMessage("ShowHint", "This door needs power"); 
				// }
			}
		}
	}

}
