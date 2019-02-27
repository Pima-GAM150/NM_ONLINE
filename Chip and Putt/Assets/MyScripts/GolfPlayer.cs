﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfPlayer : MonoBehaviour
{

    Rigidbody rbody;
    GameObject UI;
    GolfClubs clubs;


    void Awake()
    {
        clubs = FindObjectOfType<GolfClubs>();
        rbody = GetComponent<Rigidbody>();
        UI = FindObjectOfType<UIManager>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PuttBall(float power, float direction)
    {

        rbody.AddForce(clubs.clubSelection[0].transform.forward * (power * 10) * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[0].transform.right * direction * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[0].transform.forward * (power * 30) * Time.deltaTime, ForceMode.Force);
    }

    public void ChipBall(float power, float direction)
    {
        rbody.AddForce(clubs.clubSelection[1].transform.forward * (power * 10) * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[1].transform.right * direction * Time.deltaTime, ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[1].transform.forward * (power * 25) * Time.deltaTime, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cup"))
        {//pick another random start and put everything over there
               
        }
    }

}
