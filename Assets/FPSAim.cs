using UnityEngine;
using System.Collections;

public class FPSAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	float mouseX;
	float mouseY;
	public bool InvertedMouse;
	// Update is called once per frame
	void Update () {
		/*
		Vector3 mousePosition = Input.mousePosition;
		//Debug.Log (mousePosition);
		float mouseX = mousePosition.x;
		float mouseY = mousePosition.y;
		Debug.Log (transform.eulerAngles);
		*/
		// This garantees that the mouseX varialbe is not reset every time the Update() function is called. 
		mouseX += Input.GetAxis ("Mouse X");
		if (InvertedMouse) {
			mouseY += Input.GetAxis ("Mouse Y");
		} else {
			mouseY -= Input.GetAxis ("Mouse Y");
		}
		//Debug.Log (mouseX);
		transform.eulerAngles = new Vector3 (mouseY, mouseX, 0);

	}
}
