using UnityEngine;
using System.Collections;

public class MovAud : MonoBehaviour
{
	private AudioSource source;
	private void Start()
	{
		source = GameObject.FindGameObjectWithTag ("kys").GetComponent<AudioSource> ();
	}
	public void PlayAudio(AudioClip clip)
	{
		source.clip = clip;
		source.Play ();
	}

	public void StopAudio()
	{
		source.Stop ();
	}
}