using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{
	void OnCollisionEnter2D (Collision2D col)
	{

		Destroy(this.gameObject);

	}
}
