using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/BoundsInt")]
	public class AtomBoundsInt : AtomReference<BoundsInt, AtomEventHandlerBoundsInt, AtomEventBoundsInt, UnityEventBoundsInt> { }
}
