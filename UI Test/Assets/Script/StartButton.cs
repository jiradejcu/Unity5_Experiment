using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour
{
	public static CustomLobbyManager lobby;

	void Start ()
	{
		if (lobby != null)
			Destroy (lobby.gameObject);
	}

	public void LoadLobby ()
	{
		Application.LoadLevel ("NetworkTest");
	}
}
