using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Time.timeScale = 0;
	}
}
