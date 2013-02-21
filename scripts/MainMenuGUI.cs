using UnityEngine;
using System.Collections;
[RequireComponent (typeof(AudioSource))]

public class MainMenuGUI : MonoBehaviour {
	public AudioClip bleep; 
	public GUISkin menuSkin; 
	public Rect menuArea; 
	public Rect playButton; 
	public Rect instructionsButton; 
	public Rect quitButton; 
	string menuPage = "main"; 
	public Rect instructions;
	Rect menuAreaNormalized; 

	void Start(){ 
		//this sets up adaptive design 
		menuAreaNormalized = new Rect(menuArea.x * Screen.width - (menuArea.width * 0.5f), menuArea.y * Screen.height - (menuArea.height * 0.5f), menuArea.width, menuArea.height);
	}

	void OnGUI() { 
		GUI.skin = menuSkin;
		//GUI groups must begin and end BeginGroup(rect) is the syntax  
		GUI.BeginGroup(menuAreaNormalized); 
		if(menuPage == "main"){
			if(GUI.Button(new Rect(playButton), "Play")){ 
				StartCoroutine("ButtonAction", "Island");  
			} 
			if(GUI.Button(new Rect(instructionsButton), "Instructions")){
				audio.PlayOneShot(bleep);
				menuPage = "Instructions";
			}
		if(Application.platform != RuntimePlatform.OSXWebPlayer && Application.platform
			!= RuntimePlatform.WindowsWebPlayer){
			if(GUI.Button(new Rect(quitButton), "Quit")){
				StartCoroutine("ButtonAction", "quit"); 
			} 
		}
		}else if (menuPage == "Instructions"){ 
			GUI.Label(new Rect(instructions) , "you wake in a mysterious island..."); 
			
			if(GUI.Button(new Rect(quitButton), "Back")){ 
				audio.PlayOneShot(bleep); 
				menuPage = "main";
			}
		}

		GUI.EndGroup(); 
	}

	IEnumerator ButtonAction(string levelName){ 
		audio.PlayOneShot(bleep); 
		yield return new WaitForSeconds(0.35f); 

		if(levelName != "quit") { 
			Application.LoadLevel(levelName); 
		}else { 
			Application.Quit(); 
			Debug.Log("have quit");
		}
	}
}
