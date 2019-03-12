using System.Collections.Generic;
using UnityEngine;
namespace ca.HenrySoftware.Atom
{
	public abstract class AtomList<T> : ScriptableObject
	{
		public List<T> Items = new List<T>();
		public AtomEvent<T> Added;
		public AtomEvent<T> Removed;
		public AtomEvent Cleared;
		// todo: need use events!
		public void Add(T t)
		{
			if (!Items.Contains(t))
				Items.Add(t);
		}
		public void Remove(T t)
		{
			if (Items.Contains(t))
				Items.Remove(t);
		}
		public T this[int i]
		{
			get { return Items[i]; }
			set { Items[i] = value; }
		}
		public int Count => Items.Count;
		public void Clear() => Items.Clear();
		public bool Contains(T t) => Items.Contains(t);
		public void Reverse() => Items.Reverse();
	}
}
