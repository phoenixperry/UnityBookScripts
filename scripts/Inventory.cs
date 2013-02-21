using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public static int charge=0; 
	public Texture2D[] hudCharge; 
	public GUITexture chargeHudGUI; 
	public int berries; 
	//static simply means memeber of class var - and globally accessable. (does not mean that it stays the same)
	public AudioClip collectSound; 
	public Texture2D[] meterCharge; 
	public Renderer meter; 

	public GUITexture MatchGUIprefab; 
	bool haveMatches = false; 
	private GUITexture matchGUI; 
	public  GUIText textHints; 

	bool fireIsLit = false; 

	public GameObject winObj; 
	// Use this for initialization
	void Start () {
		chargeHudGUI.texture = hudCharge[charge];

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("count of cell "+ charge);
	}
	public void CellPickup() { 
		AudioSource.PlayClipAtPoint(collectSound, transform.position); 
		charge++; 
		chargeHudGUI.texture = hudCharge[charge]; 
		HUDon(); 
		meter.material.mainTexture = meterCharge[charge];
		chargeHudGUI.texture = hudCharge[charge];
	}
	void HUDon() { 
		if(!chargeHudGUI.enabled) { 
			chargeHudGUI.enabled= true; 
		}
	}
	public void BerryPickup(){ 
		berries ++; 
		Debug.Log("berry picked up "+ berries );

	}

	public void MatchPickup() {
		//Debug.Log("pick up matches") 
		haveMatches = true; 
		AudioSource.PlayClipAtPoint(collectSound, transform.position); 
		GUITexture matchHUD = Instantiate(MatchGUIprefab, new Vector3(0.15f, 0.1f, 0), transform.rotation) as GUITexture; 
		matchGUI = matchHUD; 
	}

	public void OnControllerColliderHit (ControllerColliderHit col){ 

		if(col.gameObject.name == "campfire" && haveMatches){

			LightFire(col.gameObject);
		}else if(!haveMatches && !fireIsLit && col.gameObject.name == "campfire"){
			 
			textHints.SendMessage("ShowHint", "you need to get\n the matches\n  in the cabin.");
			}
		if(col.gameObject.tag=="berry"){
			berries++; 
			Debug.Log("berry hit "+ berries);
			Destroy(col.gameObject); 
			BerryPickup(); 
					
	}		
	}
	void LightFire(GameObject campfire){ 
		Destroy(matchGUI); 
		haveMatches = false; 
		campfire.GetComponentInChildren<ParticleSystem>().Play(); 
		if(!campfire.audio){
			campfire.audio.Play(); 
		}
		fireIsLit = true; 
		winObj.SendMessage("GameOver");

	
	}


}
