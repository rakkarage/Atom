using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomEventBoundsInt : AtomEvent<BoundsInt> { }
	[Serializable]
	public class UnityEventBoundsInt : UnityEvent<BoundsInt> { }
}
