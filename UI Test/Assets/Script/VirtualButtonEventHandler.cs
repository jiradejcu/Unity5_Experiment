using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class VirtualButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
	Character[] characterList;
	int activeIndex = 0;

	void Start ()
	{
		characterList = GetComponentsInChildren<Character> ();

		// Register with the virtual buttons TrackableBehaviour
		VirtualButtonBehaviour vb = GetComponentInChildren<VirtualButtonBehaviour> ();
		if (vb) {
			vb.RegisterEventHandler (this);
		}
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("OnButtonPressed::" + vb.VirtualButtonName);

		if (!IsValid ()) {
			return;
		}

		int i = 0;
		foreach (Character c in characterList) {
			c.SetVisible (i++ == activeIndex);
		}

		activeIndex = ++activeIndex % characterList.Length;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("OnButtonReleased::" + vb.VirtualButtonName);

		if (!IsValid ()) {
			return;
		}
	}
	
	private bool IsValid ()
	{
		return true;
	}
}
