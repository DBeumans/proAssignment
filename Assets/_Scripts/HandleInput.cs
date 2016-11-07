using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HandleInput : MonoBehaviour 
{
	[SerializeField] private Button leftButton;
	[SerializeField] private Button rightButton;
	private ChangeImage changeImage;
	private PlayAnimation animation;
	private TransitionSound sound;

	private void Start()
	{
		changeImage = GetComponent<ChangeImage> ();
		animation = GetComponent<PlayAnimation> ();
		sound = GetComponent<TransitionSound> ();
		leftButton.onClick.AddListener (delegate()
		{
			changeImage.PreviousImage(); 
			animation.AniStart();
			sound.Play();
		});
		rightButton.onClick.AddListener (delegate()
		{
			changeImage.NextImage(); 
			animation.AniStart();
			sound.Play();
		});
	}
}
