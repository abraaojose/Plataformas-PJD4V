using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VolumeBarController : MonoBehaviour
{
	[SerializeField] private Slider volumeSlider;

	private void Start()
	{
		volumeSlider.onValueChanged.AddListener(VolumeSliderChanged);
	}
	private void VolumeSliderChanged(float arg0)
	{
		
	}
}
