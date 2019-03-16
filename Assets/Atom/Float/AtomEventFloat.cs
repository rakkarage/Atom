using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomEventFloat : AtomEvent<float> { }
	[Serializable]
	public class UnityEventFloat : UnityEvent<float> { }
}
