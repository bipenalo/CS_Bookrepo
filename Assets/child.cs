using UnityEngine;
using System.Collections;

public class child : Parent {

	// NOTE: The Class child has all of the functions found not only in Parent.cs but also in MonoBehavior, because the Class Parent inherited
	// all the properties of MonoBehavior. 

	// Use this for initialization
	void Start () {
		ParentAbility ();
		Debug.Log ("hola");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
