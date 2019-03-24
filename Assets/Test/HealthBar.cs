using ca.HenrySoftware.Atom;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
	public AtomInt Current;
	public AtomInt Max;
	public Gradient Colors;
	private Image _image;
	private void Awake()
	{
		_image = GetComponent<Image>();
	}
	public void UpdateCurrent(int current)
	{
		var percent = (float)Current.Value / (float)Max.Value;
		_image.color = Colors.Evaluate(percent);
		_image.fillAmount = percent;
	}
}
