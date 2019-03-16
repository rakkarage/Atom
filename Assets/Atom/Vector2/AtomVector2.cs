using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Vector2")]
	public class AtomVector2 : AtomReference<Vector2, AtomEventHandlerVector2, AtomEventVector2, UnityEventVector2> { }
}
