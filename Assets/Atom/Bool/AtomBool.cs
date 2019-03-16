using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomBool : AtomReference<bool, AtomEventHandlerBool, AtomEventBool, UnityEventBool> { }
}
