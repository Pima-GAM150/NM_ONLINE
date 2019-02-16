using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionSlider : MonoBehaviour
{
    public int scrollSpeed;
    Slider directionSlider;
    bool hitRight = false;
    bool hitLeft = false;


    void Start()
    {
        directionSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveSlider();
    }

    public void ActivateDirectionSlider()
    {
        hitLeft = true;
        
    }

    void MoveSlider()
    {
        if (hitLeft == true)
        {
            directionSlider.value += (Time.deltaTime * scrollSpeed);
            if (directionSlider.value >= directionSlider.maxValue - 1)
            {
                hitRight = true;
                hitLeft = false;
            }
        }
        if (hitRight == true)
        {
            directionSlider.value -= (Time.deltaTime * scrollSpeed);
            if (directionSlider.value <= directionSlider.minValue + 1)
            {
                hitLeft = true;
                hitRight = false;
            }


        }
    }
}
