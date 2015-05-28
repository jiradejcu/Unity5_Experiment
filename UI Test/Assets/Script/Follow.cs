using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{
	public GameObject character;

	void LateUpdate ()
	{
		if (character != null) {
			transform.position = new Vector3 (character.transform.position.x, transform.position.y, transform.position.z);
		}
	}
}
