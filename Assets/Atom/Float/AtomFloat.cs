using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu(menuName = "Atom/Float")]
	public class AtomFloat : AtomReference<float, AtomEventHandlerFloat, AtomEventFloat, UnityEventFloat> { }
}
