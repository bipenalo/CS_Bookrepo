using UnityEngine;
using System.Collections;

public class FPSMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float speed = 0.1f;
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			// Again, we use += because we don't want the position to be started every time Updat() is called.
			transform.position += transform.forward * speed;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.forward*speed;
			}
		if (Input.GetKey (KeyCode.RightArrow)) {
				transform.position += transform.right*speed;
			}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position -= transform.right*speed;
			}
		}

}
