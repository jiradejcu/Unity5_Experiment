using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.maxAngularVelocity = 100f;
		rb.angularVelocity = new Vector3 (0f, 0f, 0f);
		rb.velocity = new Vector3(10f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnGUI ()
	{
		GUI.Box (new Rect (10f, 10f, 200f, 50f), rb.angularVelocity.ToString ("G4"));
	}
}
