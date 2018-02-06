using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveCamera ();
	}
	void MoveCamera()
	{
		var oldY = this.gameObject.transform.localPosition;
		oldY.y = oldY.y - speed * Time.deltaTime;
		this.gameObject.transform.localPosition = oldY;
	}
}
