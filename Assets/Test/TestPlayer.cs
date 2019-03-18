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
			Health.Value = HealthStart.Value;
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		var mob = other.gameObject.GetComponent<TestMob>();
		if (mob != null)
			Health.Value -= mob.Damage.Value;
	}
	public void OnHealthChanged(int health)
	{
		Debug.Log(health);
	}
}
