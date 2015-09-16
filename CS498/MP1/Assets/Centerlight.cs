using UnityEngine;
using System.Collections;

public class Centerlight : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		print (gameObject.transform.position); 
		if (gameObject.transform.position.x > 0)
			transform.Find ("Centerlight").intensity = 0;
		else 
			transform.Find ("Centerlight").intensity = 40; 
	}
}
