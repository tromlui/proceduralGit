using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGen : MonoBehaviour {

	public float moveSpeed;

	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0f, 0f, moveSpeed) * Time.deltaTime);

		if (Random.Range (0f, 100f) > 99f) {
			transform.Rotate (0f, Random.Range (-360f, 360f), 0f);
		}
		
	}
}
