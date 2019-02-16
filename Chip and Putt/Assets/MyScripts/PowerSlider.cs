using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerSlider : MonoBehaviour
{

    public int scrollSpeed;
    Slider powerSlider;
    bool hitTop = false;
    bool hitBottom = false;


    void Start()
    {
        powerSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveSlider();
    }

    public void ActivatePowerSlider()
    {
        hitBottom = true;

    }

    void MoveSlider()
    {
        if (hitBottom == true)
        {
            powerSlider.value += (Time.deltaTime * scrollSpeed);
            if (powerSlider.value >= powerSlider.maxValue - 1)
            {
                hitTop = true;
                hitBottom = false;
            }
        }
        if (hitTop == true)
        {
            powerSlider.value -= (Time.deltaTime * scrollSpeed);
            if (powerSlider.value <= powerSlider.minValue + 1)
            {
                hitBottom = true;
                hitTop = false;
            }


        }
    }


}
