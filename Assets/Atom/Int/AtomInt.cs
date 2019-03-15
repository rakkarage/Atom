using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomInt : AtomReference<int, AtomEventHandlerInt, AtomEventInt, UnityEvent<int>> { }
}
