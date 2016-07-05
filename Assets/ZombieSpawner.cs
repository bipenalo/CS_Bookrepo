using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// This statement check the static numZombies value in the zombie class. This is possible only because the value is set to static, because
		//of which we've got the ability to check its value form any other class!
		if (Zombie.numZombies < 4) {
			GameObject go = GameObject.CreatePrimitive (PrimitiveType.Capsule);
			go.AddComponent (typeof(Zombie));
			go.transform.position = transform.position;
		}
	}
}
