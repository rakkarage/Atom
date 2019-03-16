using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomEventBounds : AtomEvent<Bounds> { }
	[Serializable]
	public class UnityEventBounds : UnityEvent<Bounds> { }
}
