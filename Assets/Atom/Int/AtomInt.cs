using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	[CreateAssetMenu]
	public class AtomInt :
		AtomReference<int, AtomEventHandler<int, AtomEvent<int>, UnityEvent<int>>, AtomEvent<int>, UnityEvent<int>>
	{ }
}
