using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CustomLobbyManager : NetworkLobbyManager {
	
	public delegate void EventHandler ();
	
	[SyncEvent]
	public event EventHandler
		EventLobby;
	
	public void SendEvent ()
	{
		EventLobby ();
	}

	void Start ()
	{
		StartHost();
		
		if(!NetworkServer.active)
			StartClient();

		EventLobby += OnHit;
	}

	void OnHit ()
	{
		Debug.Log("Hit");
	}

}
