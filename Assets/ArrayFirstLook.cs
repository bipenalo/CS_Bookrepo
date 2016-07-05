using UnityEngine;
using System.Collections;

public class ArrayFirstLook : MonoBehaviour {

	public GameObject[] MyGameObjects;
	public int ArrayLength;

	// Use this for initialization
	void Start () {
		float[] DynamicFloats = new float[ArrayLength];

		Debug.Log (MyGameObjects.Length);
		for (int i = 0; i < MyGameObjects.Length; i++) {
			// i.ToString converts the i variable to a string
			//MyGameObjects [i].name = i.ToString ();
		}
		foreach (GameObject go in MyGameObjects) {
			Debug.Log (go.name);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
