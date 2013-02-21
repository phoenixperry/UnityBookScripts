using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public float moveSpeed = 2f; 
	public Rigidbody bullet; 
	public float power = 1500; 
	// Update is called once per frame
	void Update () {
		
		var h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; 
		var v = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed; 
		
		transform.Translate(h,v,0); 
		if(Input.GetButtonUp("Fire1")){ 
			Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody; 
			//converts local coord space into global space - an object's forward might
			//not match that of the world so this is critical - it's also good to note that 
			//it get's the transform of the object it's attached to. In this case, the bullet 
			//also note that transform is lower case b/c the transform is local to the object 
			//it is applied to 
			Vector3 fwd = transform.TransformDirection(Vector3.forward); 

			instance.AddForce(fwd * power); 
		}		
			
	}
}
