using UnityEngine;
using System.Collections;

public class TriggerZone : MonoBehaviour {
	public Light doorLight; 
	public GUIText textHints; 
	// Use this for initialization
	void Start () {
		//Debug.Log("Trigger entered");
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider col){ 
		Debug.Log("Trigger entered");
		//note you could do the below via name 
		//if(col.gameObject.name =="First Person Controller");
		if(col.gameObject.tag == "Player") { 
			if(Inventory.charge ==4){ 
				GameObject.Find("door").SendMessage("DoorCheck"); 
				if(GameObject.Find("PowerGUI")) {
				Destroy(GameObject.Find("PowerGUI")); 
				doorLight.color = Color.green;
				}
			}
			else if (Inventory.charge < 4){ 
				textHints.SendMessage("ShowHint", "you need 4 cells");		
				//GameObject.Find("door").audio.PlayOneShot(lockedSound); 
				Debug.Log("Im getting to the else statemet");
			}		


			//findChild > find here b/c it only seraches children not whole game 
		}
	}

}