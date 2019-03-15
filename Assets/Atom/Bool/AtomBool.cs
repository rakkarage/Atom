using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomBool :
		AtomReference<bool, AtomEventHandler<bool, AtomEvent<bool>, UnityEvent<bool>>, AtomEvent<bool>, UnityEvent<bool>>
	{ }
}
