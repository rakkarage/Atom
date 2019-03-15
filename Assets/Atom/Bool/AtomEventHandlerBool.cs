using System;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[Serializable]
	public class AtomEventHandlerBool : AtomEventHandler<bool, AtomEventBool, UnityEvent<bool>> { }
}