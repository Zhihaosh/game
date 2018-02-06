using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	Rigidbody2D playerRigidbody2D;
	public float speedX;

	public float horizontalDirection;

	const string HORIZONTAL = "Horizontal";

	public float xForce;

	float speedY;

	public float maxSpeedX;

	public void ControlSpeed(){
		speedX = playerRigidbody2D.velocity.x;
		speedY = playerRigidbody2D.velocity.y;
		float newSpeedX = Mathf.Clamp (speedX, -maxSpeedX, maxSpeedX);
		playerRigidbody2D.velocity = new Vector2 (newSpeedX, speedY);
	}
	public float yForce;

	public bool JumpKey{
		get{ 
			return Input.GetKeyDown (KeyCode.Space);
		}

	}

	void TryJump(){
		if (IsGround && JumpKey) {
			playerRigidbody2D.AddForce (Vector2.up * yForce);
		}
	}

	// Use this for initialization
	void Start () {
		playerRigidbody2D = GetComponent<Rigidbody2D> ();
	}

	void MovementX(){
		horizontalDirection = Input.GetAxis (HORIZONTAL);
		playerRigidbody2D.AddForce (new Vector2(xForce*horizontalDirection, 0));
	}

	public Transform groundCheck;

	public LayerMask groundLayer;

	public bool grounded;
	public float distance;

	bool IsGround{
		get{ 
			Vector2 start = groundCheck.position;
			Vector2 end = new Vector2 (start.x, start.y - distance);
			Debug.DrawLine (start, end, Color.blue);
			grounded = Physics2D.Linecast (start, end, groundLayer);
			return grounded;
		}
	}

	// Update is called once per frame
	void Update () {
		MovementX ();
		ControlSpeed ();
		TryJump();
	}
}
