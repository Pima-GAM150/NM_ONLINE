using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class GolfPlayer : MonoBehaviourPun, IPunObservable
{
    
     Rigidbody rbody;
    GameObject UI;
    GolfClubs clubs;
    public Camera playerCam;

    public int currentHole =0;
    public GolfCourse teeList;

    void Awake()
    {
        teeList = FindObjectOfType<GolfCourse>();
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
        if (photonView.IsMine)
        {
            rbody.AddForce(clubs.clubSelection[0].transform.forward * (power), ForceMode.Impulse);
            rbody.AddForce(clubs.clubSelection[0].transform.right * direction, ForceMode.Impulse);
            rbody.AddForce(clubs.clubSelection[0].transform.forward * (power), ForceMode.Force);
        }
    }

    public void ChipBall(float power, float direction)
    {
        rbody.AddForce(clubs.clubSelection[1].transform.forward * (power), ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[1].transform.right * direction, ForceMode.Impulse);
        rbody.AddForce(clubs.clubSelection[1].transform.forward * (power), ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        int nextHole = UnityEngine.Random.Range(0, teeList.startingSpots.Length);



        if (other.CompareTag("Cup"))
        {
            Debug.Log("In hole");
            transform.position = teeList.startingSpots[nextHole].transform.position;
            currentHole = nextHole;
        }
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        
    }
}
