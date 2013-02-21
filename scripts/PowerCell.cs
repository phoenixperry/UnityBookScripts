using UnityEngine;
using System.Collections;

public class PowerCell : MonoBehaviour {
	public float rotationSpeed = 100.0f; 
	public float myX; 
	public float myY; 
	public float myZ; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,rotationSpeed * Time.deltaTime,0)); 
	}
	void OnTriggerEnter(Collider col) { 
		//this is the default function that handles functionality of isTrigger is checked in inspector
		if(col.gameObject.tag == "Player"){
			col.gameObject.SendMessage("CellPickup"); 
		
			Destroy(gameObject); 
		}


	}

}
