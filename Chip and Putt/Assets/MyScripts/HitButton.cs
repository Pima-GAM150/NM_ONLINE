using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitButton : MonoBehaviour
{
    public GolfPlayer playerBall;
    public Slider powerStrength;
    public Slider direction;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerBall = FindObjectOfType<GolfPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonHitIsClicked()
    {
        Debug.Log("Swing at ball with " + powerStrength.value + " & " + direction.value);
        playerBall.HitBall(powerStrength.value, direction.value);
    }

}
