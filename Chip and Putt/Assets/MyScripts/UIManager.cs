using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Slider powerMeter;
    public Slider directionMeter;
    public Button chipButton;
    public Button puttButton;
    public Text playersHole;
    public Text strokeDisplay;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (powerMeter.GetComponent<PowerAndDirectionSliders>().clickCount % 2 == 0 && directionMeter.GetComponent<PowerAndDirectionSliders>().clickCount % 2 == 0 && powerMeter.GetComponent<PowerAndDirectionSliders>().clickCount != 0 && directionMeter.GetComponent<PowerAndDirectionSliders>().clickCount != 0)
        {
            puttButton.gameObject.SetActive(true);
            chipButton.gameObject.SetActive(true);
        }
        else {
            puttButton.gameObject.SetActive(false);
            chipButton.gameObject.SetActive(false);
        }


    }


    public void HoleNumberUpdate(int holeNum)
    {

        playersHole.text = "Hole " + holeNum.ToString();
    }

    public void StrokeNumberUpdate(int strokeNum, int totalStrokes)
    {

        strokeDisplay.text = "Stroke " + strokeNum.ToString() + "\n Total Strokes " + totalStrokes.ToString();


    }

}
