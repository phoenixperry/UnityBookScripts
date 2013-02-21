using UnityEngine;
using System.Collections;

public class MatchesTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onTriggerEnter(Collider col){ 
		Debug.Log("matches picked up");
	}
}
