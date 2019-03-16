using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomEventVector3 : AtomEvent<Vector3> { }
	[Serializable]
	public class UnityEventVector3 : UnityEvent<Vector3> { }
}
