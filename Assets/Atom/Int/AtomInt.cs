using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Int")]
	public class AtomInt : AtomReference<int, AtomEventHandlerInt, AtomEventInt, UnityEventInt> { }
}
