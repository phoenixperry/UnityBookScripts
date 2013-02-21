using UnityEngine;
using System.Collections;

public class Matches : MonoBehaviour {

	void Start(){ 
		Debug.Log("hey I at least was started"); 
		//Debug.Log(col.isTrigger, "i'm triggering - matches");
	}
	//note this function is uppercase 
	void OnTriggerEnter(Collider col) { 
		if(col.gameObject.tag == "Player"){ 
			col.gameObject.SendMessage("MatchPickup"); 
			Destroy(gameObject); 
			Debug.Log("matches working");
		}
		if( rigidbody.IsSleeping() )
		{
		    col.isTrigger = true;
		    rigidbody.isKinematic = true;
		    Debug.Log( "exited vehicle" );
		}
	}
}
