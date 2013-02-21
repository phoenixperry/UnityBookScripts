using UnityEngine;
using System.Collections;

public class accessingFunctions : MonoBehaviour {
	public ToAccess toAccess; 

	// Use this for initialization
	void Start () {
		//ok as redic as this is going to seem,  you can't 
		//call new in this case. Unlike Processing, New is not
		//allowed on objects inherited from MonoBehavior
		//rather you must find the object this script is 
		//on and then get the component of that script
		GameObject go = GameObject.Find("ToMove"); 
		toAccess = (ToAccess) go.GetComponent(typeof(ToAccess)); 

	}
	
	// Update is called once per frame
	void Update () {
		toAccess.example(); 
		transform.Rotate(0,1,0);
	}
}
