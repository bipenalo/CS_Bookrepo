using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// store the position of the player
	Vector3 pos;

	// Use this for initialization
	void Start () {
		// set the position to where we start off in the scene
		pos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		bool Wkey = Input.GetKey (KeyCode.W);
		bool Skey = Input.GetKey (KeyCode.S);
		bool Akey = Input.GetKey (KeyCode.A);
		bool Dkey = Input.GetKey (KeyCode.D);

		if (Akey) {
			Debug.Log ("Akey");
			//calls the static funcion in Zombie
			Zombie.CountZombies();
			pos.x -= 0.1f;
		}
		if (Wkey) {
			pos.z += 0.1f;
		}
		if (Skey) {
			pos.z -= 0.1f;
		}
		if (Dkey) {
			pos.x += 0.1f;
		}
		gameObject.transform.position = pos;
	}
}
