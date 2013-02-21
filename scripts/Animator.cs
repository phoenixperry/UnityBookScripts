using UnityEngine;
using System.Collections;

public class Animator : MonoBehaviour {
	public float xStartPostion = -1.0f; 
	public float xEndPositon = 0.5f; 
	public float speed = 1.0f; 
	float startTime; 

	// Use this for initialization
	void Start () {
		startTime = Time.time; 
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = new Vector3(Mathf.Lerp(xStartPostion, xEndPositon, (Time.time-startTime)*speed), transform.position.y, transform.position.z); 
		transform.position = pos; 
	}
}
