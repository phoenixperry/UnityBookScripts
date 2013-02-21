using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour {
	bool doorIsOpen = false; 
	public float doorTimer = 3.0f; 
	public AudioClip doorOpenSound; 
	public AudioClip doorShutSound; 
	//private GameObject temp; 
	private float doorOpenTime = 3.0f; 
    GameObject currentDoor; 
    
	private GameObject door; 

	// Use this for initialization
	void Start () {
	//	temp = GameObject.Find("GameController"); 
	}
	
	// Update is called once per frame
	void Update () {
		if(doorIsOpen) { 
			doorTimer +=Time.deltaTime; 
		}
		if(doorTimer > doorOpenTime && currentDoor){ 
			Door(doorShutSound, false, "doorshut", currentDoor); 
			doorTimer = 0.0f; 
		}
	}
//how to do extended collider checks 

	void OnControllerColliderHit(ControllerColliderHit hit){ 
		//function available to charactter controllers expecting a hit passed into it. hit is what the character just hit
		if(hit.gameObject.tag == "playerDoor" && doorIsOpen == false){ 
			currentDoor = hit.gameObject;
			Door(doorOpenSound, true, "dooropen", currentDoor); 
			Debug.Log("registering hit"); 
		}	
	}	
	
	// void OpenDoor(GameObject door) { 
	// 	doorIsOpen = true; 
	// 	door.audio.PlayOneShot(doorOpenSound); 
	// 	//remember door is the tagged object playerDoor 
	// 	door.transform.parent.animation.Play("dooropen");
	// }
	// void ShutDoor(GameObject door){ 
	// 	doorIsOpen = false; 
	// 	door.audio.PlayOneShot(doorShutSound); 
	// 	door.transform.parent.animation.Play("doorshut"); 
	// }
	void Door(AudioClip aClip, bool openCheck, string animName, GameObject thisDoor) { 
		thisDoor.audio.PlayOneShot(aClip); 
		doorIsOpen = openCheck; 
		thisDoor.transform.parent.animation.Play(animName); 
	}
}
