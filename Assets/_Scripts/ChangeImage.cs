using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
	[SerializeField] private Sprite[] images; 
	[SerializeField] private Image display;
	private int i;
	private void Start()
	{
		i = 0;
		display.sprite = images [i];

	}
	public void NextImage ()
	{
		i++;
		if (i > images.Length - 1)
		{
			i = 0;
		}
		display.sprite = images [i];
	}

	public void PreviousImage()
	{
		i--;
		if(i<0)
		{
			i=images.Length-1;
		}
		display.sprite = images[i];
	}
}
