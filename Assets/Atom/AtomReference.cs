using UnityEngine;
namespace ca.HenrySoftware.Atom
{
	public abstract class AtomReference<T> : ScriptableObject
	{
		public T Value;
		// todo: need events!
	}
}
