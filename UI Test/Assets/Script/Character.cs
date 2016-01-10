using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
	public int characterNo;
	MeshRenderer mr;

	void Start ()
	{
		mr = GetComponentInChildren<MeshRenderer> ();
	}

	public void SetVisible (bool visible)
	{
		mr.enabled = visible;
	}
}
