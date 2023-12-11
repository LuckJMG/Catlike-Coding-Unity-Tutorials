using System;
using UnityEngine;

public class Clock : MonoBehaviour {
	[SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;

	const float hoursToDegrees = -30f;
	const float minutesToDegrees = -6f;
	const float secondsToDegrees = -6f;

	void Update() {
		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
		minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
		secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
	}
}