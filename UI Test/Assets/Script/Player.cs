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
}
