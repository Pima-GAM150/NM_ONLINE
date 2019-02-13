using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionSlider : MonoBehaviour
{

    Slider directionSlider;
    bool hitRight = false;
    bool hitLeft = true;


    void Start()
    {
        directionSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        ActivateDirectionSlider();
    }

    public void ActivateDirectionSlider()
    {

        if (hitLeft == true)
        {
            directionSlider.value += Time.deltaTime;
            if (directionSlider.value >= directionSlider.maxValue - 1)
            {
                hitRight = true;
                directionSlider.value -= Time.deltaTime;
            }
        }
        if (hitRight == true)

        {
            directionSlider.value -= Time.deltaTime;
            if (directionSlider.value <= directionSlider.minValue + 1)
            {
                hitLeft = true;
                directionSlider.value += Time.deltaTime;
            }


        }
    }
}
