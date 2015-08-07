using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Target : NetworkBehaviour
{
	public Player player;

	// Use this for initialization
	void Start ()
	{
		if (player != null)
			player.EventFire += OnHit;
	}

	void OnHit ()
	{
		Debug.Log ("Hit");
	}
}
