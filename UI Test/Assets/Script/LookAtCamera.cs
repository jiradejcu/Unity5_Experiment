using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 direction = Camera.main.transform.forward;
		Debug.Log (direction);
		transform.rotation = Quaternion.LookRotation (-direction);
	}
}
