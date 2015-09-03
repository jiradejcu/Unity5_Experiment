using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class CustomLobbyManager : NetworkLobbyManager
{
	void Start ()
	{
		networkSceneName = "";
		StartButton.lobby = this;

		StartHost ();
		
		if (!NetworkServer.active)
			StartClient ();
	}

	void OnGUI ()
	{
		if (!isNetworkActive && Application.loadedLevelName.Equals ("PhysicTest") && GUI.Button (new Rect (400, 10, 100, 30), "Exit")) {
			Application.LoadLevel ("Main");
		}

		GUI.Box(new Rect (400, 100, 200, 300), "Offline : " + offlineScene + "\nOnline : " + onlineScene + "\nLobby : " + lobbyScene + "\nPlay : " + playScene + "\nNetwork : " + networkSceneName);
	}
	
	void ClearOfflineScene ()
	{
		offlineScene = "";
	}
	
	public override void OnLobbyClientSceneChanged (NetworkConnection conn)
	{
		ClearOfflineScene ();
	}
}
