using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float CountdownInSecTime;  // 2025 03 31: altered script to accept an argument, allowing for re-use throughout project for various timers concurent or otherwise
    
    // Update is called once per frame
    void Update()
    {
        
            if (CountdownInSecTime > 0)                      // countdown
            {
                CountdownInSecTime -= Time.deltaTime;
            }
            else if (CountdownInSecTime < 0)                  // stop countdown, and do end of timer things. Like; StartInvasion(); &/o GameOver();
            {
                CountdownInSecTime = 0;

                timerText.color = Color.red;
            }

            int minutes = Mathf.FloorToInt(CountdownInSecTime / 60);
            int seconds = Mathf.FloorToInt(CountdownInSecTime % 60);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }
}
