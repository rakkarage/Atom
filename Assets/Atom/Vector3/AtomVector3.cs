using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomVector3 : AtomReference<Vector3, AtomEventHandlerVector3, AtomEventVector3, UnityEventVector3> { }
}
