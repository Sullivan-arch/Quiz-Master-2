using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Timer : MonoBehaviour
{
    [SerializeField] float timerToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion;
    public float fillFraction;
    float timerValue;


    void Update()
    {
        updateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void updateTimer()
    {
        timerValue -= Time.deltaTime;


        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timerToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timerToCompleteQuestion;
                loadNextQuestion = true;
       
            }
        }
        Debug.Log(isAnsweringQuestion + ":" + timerValue + "=" + fillFraction);
    }

}
