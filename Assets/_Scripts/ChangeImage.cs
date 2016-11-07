using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
	[SerializeField] private Texture[] images; 
	[SerializeField] private RawImage display;
	private MovAud playAud;
	private int i;
	private float timer;
	private bool yes;
	private void Start()
	{
		playAud = GetComponent<MovAud> ();
		i = 0;
		yes = true;
		timer = 20f;
		display.texture = images [i];
		StartCoroutine (Auto());
	}
	public void NextImage ()
	{
		i++;
		Check ();
		timer = 20f;
	}
	private void Check()
	{
		if (i > images.Length - 1)
		{
			i = 0;
		}
		if(i<0)
		{
			i=images.Length-1;
		}
		if (images [i].GetType () == typeof(MovieTexture))
		{
			MovieTexture currentSlide = (MovieTexture)images [i];
			display.texture = currentSlide;
			currentSlide.Play ();
			playAud.PlayAudio (currentSlide.audioClip);
			currentSlide.loop = true;
		} else
		{
			playAud.StopAudio ();
		}
		display.texture = images [i];
	}

	public void PreviousImage()
	{
		i--;
		Check ();
		timer = 20f;
	}

	IEnumerator Auto ()
	{
		while (yes)
		{
			timer -= Time.deltaTime;
			if (timer <= 0)
			{
				i++;
				Check ();
				timer = 20f;
			}
			yield return null;
		}
	}
}
