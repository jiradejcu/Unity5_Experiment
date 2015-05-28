using UnityEngine;
using System.Collections;

public class Airplane : MonoBehaviour
{
	Rigidbody rb;
	public float cl = 1f;
	public float velocity;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.maxAngularVelocity = 100f;
		rb.angularVelocity = new Vector3 (0f, 0f, 0f);
		rb.velocity = new Vector3 (10f, 0f, 0f);
	}

	void FixedUpdate ()
	{
		velocity = rb.velocity.magnitude;
		rb.AddRelativeForce (new Vector3 (0f, cl * rb.velocity.x, 0f));
	}
}
