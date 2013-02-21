using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {
	bool doorIsOpen = false; 
	public float doorTimer = 0.0f; 
	public AudioClip doorOpenSound; 
	public AudioClip doorShutSound; 
	public AudioClip lockedSound; 
	
	//test
	private float doorOpenTime = 3.0f; 

	// Use this for initialization
	void Start () {
			doorTimer = 0.0f;  
	}
	
	// Update is called once per frame
	void Update () {
		if(doorIsOpen) { 
			doorTimer +=Time.deltaTime; 
		}
		if(doorTimer > doorOpenTime){ 
			Door(doorShutSound, false, "doorshut"); 
			doorTimer = 0.0f; 
		}
	}
	public void DoorCheck() { 
		
		if (!doorIsOpen){ 
			Door(doorOpenSound, true, "dooropen"); 
		}
	}

	public void Door(AudioClip aClip, bool openCheck, string animName) { 
	
			audio.PlayOneShot(aClip); 
			doorIsOpen = openCheck; 
			transform.parent.gameObject.animation.Play(animName); 
	}
	
	}	
//	if(Raycast hit(transform.postion, transform.foward, out, hit, 3)); 


	
