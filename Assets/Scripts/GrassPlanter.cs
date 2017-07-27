using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassPlanter : MonoBehaviour {

	public GameObject grass;
	public int maxGrass;

	// Use this for initialization
	void Start () {

		int grassCounter = 0;

		while (grassCounter<maxGrass) {
			Instantiate (grass, 
				new Vector3 (Random.Range (-10f, 10f), 1f, Random.Range (-10f, 10f)), 
				Quaternion.Euler (0f, Random.Range (0f, 360f), 0f));
			grassCounter++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
