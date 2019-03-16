using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Bool")]
	public class AtomBool : AtomReference<bool, AtomEventHandlerBool, AtomEventBool, UnityEventBool> { }
}
