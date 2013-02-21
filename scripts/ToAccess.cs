using UnityEngine;
using System.Collections;

public class ToAccess : MonoBehaviour {
	GameObject temp;	
	public float smooth = 2.0F;
	// Use this for initialization
	void Start () {

    //note that you have to deal with paths on a find
	 temp = GameObject.Find("/Mover"); 
	 //if for some reason you need to get a game object - do it here not in update

	 Debug.Log("i've been inited");
	}
	
	// Update is called once per frame
	void Update () {
	//note in external functions you can't do this w/out getting 
	//the object 

	transform.Translate(0,1,0);
	}
	public void example() { 
		//Debug.Log("Hello! I'm the happy sphere!"); 
		//this moves the sphere locally 
		transform.Translate(1,1,1);
		
		//this moves the cube down from inside this script attached
		//to the sphere 
		temp.GetComponent<Transform>().Translate(0,-1,0);
		Transform saveTemp = temp.GetComponent<Transform>();
		saveTemp.transform.rotation=Quaternion.identity;
		
	 }
} 