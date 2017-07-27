using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsotericOrderOfDagon : MonoBehaviour {

	public FishGen fish;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			FishGen newFishClone = Instantiate (fish, Vector3.zero, Quaternion.identity);
			newFishClone.moveSpeed = Random.Range (1f, 10f);
			newFishClone.transform.localScale *= Random.Range (0.1f, 10f);
		}
		
	}
}
