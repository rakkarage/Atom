using UnityEngine;
namespace ca.HenrySoftware.Atom
{
	public abstract class AtomReference<T> : ScriptableObject
	{
		public AtomEvent<T> Changed;
		private T _value;
		public T Value
		{
			get { return _value; }
			set
			{
				_value = value;
				Changed.Raise(_value);
			}
		}
	}
}
