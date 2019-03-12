using ca.HenrySoftware.Atom;
using UnityEngine;
public class TestPlayer : MonoBehaviour
{
	public AtomInt Health;
	public AtomInt HealthStart;
	public bool Reset = true;
	private void Start()
	{
		if (Reset)
			Health = HealthStart;
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		TestMob mob = other.gameObject.GetComponent<TestMob>();
		Debug.Log(mob.name);
		// if (mob != null)
		// 	Health -= mob.Damage;
	}
}
