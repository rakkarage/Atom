using UnityEngine;
using UnityEngine.Events;
namespace ca.HenrySoftware.Atom
{
	public class AtomEventHandler : MonoBehaviour
	{
		public AtomEvent Event;
		public UnityEvent Response;
		protected void OnEnable() => Event?.Register(this);
		protected void OnDisable() => Event?.Unregister(this);
		public void Invoke() => Response?.Invoke();
	}
	public abstract class AtomEventHandler<T> : AtomEventHandler
	{
		public new AtomEvent<T> Event;
		public new UnityEvent<T> Response;
		public void Invoke(T t) => Response?.Invoke(t);
	}
}
