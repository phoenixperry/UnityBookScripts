using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {
	public GUITexture loadGUI; 

	// Use this for initialization
	void Start () {
		//this script makes the background adaptive - it deals with 
		//the offset for the x + y and then functionally 
		//insets it to 0,0 for every res. 
		Rect currentRes = new Rect(-Screen.width *0.5f, -Screen.height *0.5f, Screen.width, Screen.height);
		guiTexture.pixelInset = currentRes; 	
	}
	
	// Update is called once per frame
	public void LoadAnim(){ 
		Instantiate (loadGUI); 
	}
}
