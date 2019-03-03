using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerAndDirectionSliders : MonoBehaviour
{

    public int scrollSpeed;
    Slider sliderMeter;
    bool hitTop = false;
    bool hitBottom = true;
    bool isActive = false;
    public int clickCount = 0;


    void Start()
    {
        sliderMeter = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveSlider();

        if (clickCount % 2 != 0)
        {
            isActive = true;
        }
        else isActive = false;
    }

    public void ActivateSlider()
    {
        clickCount++;

    }

    public void ResetClickCount()
    {

        clickCount = 0;
    }

    void MoveSlider()
    {
        if (isActive)
        {
            if (hitBottom)
            {
                sliderMeter.value += (Time.deltaTime * scrollSpeed);
                if (sliderMeter.value >= sliderMeter.maxValue)
                {
                    hitTop = true;
                    hitBottom = false;
                }
            }
            if (hitTop)
            {
                sliderMeter.value -= (Time.deltaTime * scrollSpeed);
                if (sliderMeter.value <= sliderMeter.minValue)
                {
                    hitBottom = true;
                    hitTop = false;
                }


            }
        }

    }


}
