using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CustomLobbyManager : NetworkLobbyManager
{
	
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
		StartHost ();
		
		if (!NetworkServer.active)
			StartClient ();

		EventLobby += OnHit;
	}

	void OnGUI ()
	{
		if (!isNetworkActive && Application.loadedLevelName.Equals("PhysicTest") && GUI.Button (new Rect (400, 10, 100, 30), "Exit")) {
			Application.LoadLevel ("NetworkTest");
		}
	}

	void OnHit ()
	{
		Debug.Log ("Hit");
	}
	
	public override void OnLobbyClientSceneChanged (NetworkConnection conn)
	{
		Debug.Log ("OnLobbyClientSceneChanged");
		this.offlineScene = "PhysicTest";
	}
	
	public override void OnLobbyServerSceneChanged (string sceneName)
	{
		Debug.Log ("OnLobbyServerSceneChanged : " + sceneName);
		this.offlineScene = "PhysicTest";
	}

}
