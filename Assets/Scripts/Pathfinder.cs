using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pathfinder : MonoBehaviour {

	private int counter = 0;
	public Transform floorPrefab;
	public GameObject pathmakerSpherePrefab;

	public int pathNumA;

	public GameObject meteor1;
	public GameObject meteor2;
	public GameObject meteor3;

	void Start () {
		pathNumA = Random.Range (10, 100);
	}

	// Update is called once per frame
	void Update () {
		if (counter < pathNumA) {
			float ran = Random.Range (0.0f, 1.0f);
			if (ran < 0.25f) {
				pathmakerSpherePrefab.transform.Rotate (0, 90, 0);
			} else if (0.25f < ran && ran < 0.5f) {
				pathmakerSpherePrefab.transform.Rotate (0, -90, 0);
			} else if (0.99f < ran && ran < 1.0f) {
				Instantiate (pathmakerSpherePrefab);
			} else {
				//Instantiate (floorPrefab, transform.position, transform.rotation);
				float meteors = Random.Range (0.0f, 3.0f);
				if (meteors <= 1.0f) {
					Instantiate (meteor1, transform.position, transform.rotation);
				} else if (1.0 < meteors && meteors <= 2.0) {
					Instantiate (meteor2, transform.position, transform.rotation);
				} else {
					Instantiate (meteor3, transform.position, transform.rotation);
				}
				transform.Translate (0, 0, 5);
				
			}
			counter++;
		} else {
			Destroy (pathmakerSpherePrefab);
		}
	}
}
