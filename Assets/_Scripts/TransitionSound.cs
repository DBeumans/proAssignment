using UnityEngine;
using System.Collections;

public class TransitionSound : MonoBehaviour 
{
	[SerializeField] private AudioClip transitionAudio;
	private AudioSource source;
	private void Start()
	{
		source = GetComponent<AudioSource> ();
	}
	public void Play()
	{
		if (source.isPlaying)
		{
			source.Stop ();
		}
		source.loop = false;
		source.PlayOneShot (transitionAudio);
	}
}
