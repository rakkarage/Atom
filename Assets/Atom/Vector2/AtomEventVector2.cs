using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomEventVector2 : AtomEvent<Vector2> { }
	[Serializable]
	public class UnityEventVector2 : UnityEvent<Vector2> { }
}
