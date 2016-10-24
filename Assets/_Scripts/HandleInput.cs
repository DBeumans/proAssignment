using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HandleInput : MonoBehaviour 
{
	[SerializeField] private Button leftButton;
	[SerializeField] private Button rightButton;
	private ChangeImage changeImage;

	private void Start()
	{
		changeImage = GetComponent<ChangeImage> ();
		leftButton.onClick.AddListener (delegate(){changeImage.PreviousImage();});
		rightButton.onClick.AddListener (delegate(){changeImage.NextImage();});
	}
}
