using UnityEngine;
using System.Collections;

public class Lightswitch : MonoBehaviour {
		public Light centerlight;

	void Start () {
		centerlight = GetComponent <Light>(); 
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Tab)) {
			if (centerlight.intensity == 0)
				centerlight.intensity = 5;
			else 
				centerlight.intensity = 0;
		}
	}
}
