using System;
using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Bool")]
	public class AtomEventBool : AtomEvent<bool> { }
	[Serializable]
	public class UnityEventBool : UnityEvent<bool> { }
}
