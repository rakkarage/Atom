using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Bounds")]
	public class AtomBounds : AtomReference<Bounds, AtomEventHandlerBounds, AtomEventBounds, UnityEventBounds> { }
}
