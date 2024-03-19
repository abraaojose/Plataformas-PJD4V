using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class AudioObserverManager
{
	public static  event Action<float>OnVolumeChanged;

    public static void VolumeChanged(float volume)
   {
	   OnVolumeChanged?.Invoke(volume);
   }
}
