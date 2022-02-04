using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] Image backgroundTimer;
    [SerializeField] float duration, currentTime;
    void Start()
    {
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while(currentTime > 0)
        {
            timeText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        Debug.Log("notime");
        
    }
}
