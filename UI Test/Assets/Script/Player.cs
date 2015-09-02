using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Player : NetworkBehaviour
{
	public delegate void EventHandler ();

	[SyncEvent]
	public event EventHandler
		EventFire;

	public void Fire ()
	{
		EventFire ();
	}

	void Start ()
	{
		if (!isLocalPlayer && netId.Value != 0) {
			gameObject.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController> ().enabled = false;
			gameObject.GetComponentInChildren<AudioListener> ().enabled = false;
			gameObject.GetComponentInChildren<Camera> ().enabled = false;
		}
	}
}
