using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour {

	public GameObject ChildObject;

	// Use this for initialization
	void Start () {

		// Constructor
		//Vector3 vector = new Vector3(1,2,3);
		//vector.x = 2.0f;
		//transform.position = vector;

		// OR
		//transform.position = new Vector3(1,2,3);

		Debug.Log (MyFunction (7));
		// instantiation of PianoCat class
		PianoCat famousCat = new PianoCat ();
		famousCat.PlayPiano ();
		famousCat.Meow ();

		GameObject[] gos = GameObject.FindObjectsOfType (typeof(GameObject)) as GameObject[];

		foreach (GameObject go in gos) 
		{
			//Debug.Log (go);
			Component comp = go.GetComponent (typeof(child));
			if (comp != null) 
			{
				ChildObject = go;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int MyFunction(int n) {
		return n;
	}
	public class Cat
	{
		public static int Paws = 4;
		public void Meow(){
			//Debug.Log ("Meow");
		}
	}
	// Class PianoCat inherits from the base class Cat.
	public class PianoCat:Cat
	{
		public void PlayPiano()
		{
			Meow (); // inherited form Cat
		}
	}
}
