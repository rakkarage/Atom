using System.Collections.Generic;
using UnityEngine;
namespace ca.HenrySoftware.Atom
{
	public class AtomEvent : ScriptableObject
	{
		private List<AtomEventHandler> Handlers = new List<AtomEventHandler>();
		public void Register(AtomEventHandler handler) => Handlers.Add(handler);
		public void Unregister(AtomEventHandler handler) => Handlers.Remove(handler);
		public void Raise()
		{
			for (var i = Handlers.Count - 1; i > 0; i--)
				Handlers[i].Invoke();
		}
	}
	public abstract class AtomEvent<T> : AtomEvent
	{
		private List<AtomEventHandler<T>> Handlers = new List<AtomEventHandler<T>>();
		public void Register(AtomEventHandler<T> handler) => Handlers.Add(handler);
		public void Unregister(AtomEventHandler<T> handler) => Handlers.Remove(handler);
		public void Raise(T t)
		{
			for (var i = Handlers.Count - 1; i > 0; i--)
				Handlers[i].Invoke(t);
		}
	}
}
