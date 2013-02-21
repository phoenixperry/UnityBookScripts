using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {
	public GameObject winSequence; 
	public GUITexture fader; 
	public AudioClip winClip; 
	
	IEnumerator GameOver() { 
		AudioSource.PlayClipAtPoint(winClip, transform.position); 
		Instantiate(winSequence); //instantiates our prefab 
		yield return new WaitForSeconds(8.0f); 
		Instantiate(fader); 
	}
}
