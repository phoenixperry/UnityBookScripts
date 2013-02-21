using UnityEngine;
using System.Collections;

public class TinyObject : MonoBehaviour {
	public float removeTime = 3.0f;
	// Use this for initialization
	void Start () {
			Destroy(gameObject, removeTime); 
	}
	
	// Update is called once per frame

}