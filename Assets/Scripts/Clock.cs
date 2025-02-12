using System;
using UnityEngine;


public class Clock : MonoBehaviour {

    const float hoursToDegrees = -30f, minutesToDegreees = -6f, secondsToDegrees = -6f;

    [SerializeField] 
    Transform hoursPivot, minutesPivot, secondsPivot;


    void Update (){
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0f, minutesToDegreees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0f, secondsToDegrees * (float)time.TotalSeconds);


    }

}