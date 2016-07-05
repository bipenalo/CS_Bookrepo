using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	// static means that this variable (numZombies) is shared by ALL objects that have the Zombie.cs script attached.  
	public static int numZombies;
	public bool die;
	public GameObject player;
	public float speed = 0.01f;

	//private GameObject cap;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Main Camera");
		numZombies++;
		Debug.Log (numZombies);


		//cap = GameObject.Find ("Capsule");
		//if (cap != null) {
			//Debug.Log (cap);
			//Renderer rend = GetComponent<Renderer> ();
			//rend.material.shader = Shader.Find ("Standard");
			//rend.material.SetColor ("_SpecColor", Color.blue);
		//}

	}

	// Static function
	public static void CountZombies()
	{
		Debug.Log (numZombies);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = (player.transform.position - transform.position).normalized;
		float distance = (player.transform.position - transform.position).magnitude;

		Vector3 move = transform.position + (direction * speed);
		transform.position = move;

		if (distance < 1f) {
			die = true;
		}

		if (die) {
			numZombies--;
			Destroy (gameObject);
		}
	}
}
