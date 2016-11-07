using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

	[SerializeField] private Animation animation;

	public void AniStart ()
	{
		animation.Play ();
	}
}
