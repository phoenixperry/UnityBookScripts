using UnityEngine;
using System.Collections;

public class gameObjsArray : MonoBehaviour {
	public GameObject[] goomba; 
	//array for objects 
	void Start () {
		goomba = GameObject.FindGameObjectsWithTag("enemy");
		Debug.Log(goomba.Length); 
	}
	
	public int l,h = 0; 
	
	void Update() { 
		//this just moves all the game objects in my array 
		for(int i =0; i < goomba.Length; i++){ 
			GameObject temp = goomba[i]; 
			temp.transform.Translate(l,0,h); 
			l++; 
			h++; 
		} 
	}
	//this is the level changer 
	void OnGUI() { 
		GUILayout.Label("press s to start game"); 
		if(Event.current.Equals(Event.KeyboardEvent("s")))
		{Application.LoadLevel("startGame"); }
			
		if(Event.current.Equals(Event.KeyboardEvent("return")))
	{		{print("I said enter not return"); }
	} 
}
}

