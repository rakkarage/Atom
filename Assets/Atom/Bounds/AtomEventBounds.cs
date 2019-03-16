using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Bounds")]
	public class AtomEventBounds : AtomEvent<Bounds> { }
	[Serializable]
	public class UnityEventBounds : UnityEvent<Bounds> { }
}
