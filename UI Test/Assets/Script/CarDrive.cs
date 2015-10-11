using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Vehicles.Car;

public class CarDrive : MonoBehaviour
{
	public CarController carController;
	float? curve;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.R)) {
			curve = 1f;
			gameObject.transform.position = Vector3.zero;
			gameObject.transform.rotation = Quaternion.identity;
		}
		
		if (curve.HasValue) {
			float accel = 1f;				
			carController.Move (curve.Value, accel, accel, 0f);

			if(gameObject.transform.rotation.y > 90)
				curve = null;
		}
	}
}
