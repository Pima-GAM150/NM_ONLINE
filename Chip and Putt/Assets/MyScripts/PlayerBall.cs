using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class PlayerBall : MonoBehaviour
{

    public Mesh[] ballSelection;
    public GameObject currentball;
    public Camera playerCam;

    int randomBall;

    public void Awake()
    {
       

    }


    [PunRPC]
    public void SetColor()
    {
        randomBall = UnityEngine.Random.Range(0, ballSelection.Length);
        currentball.GetComponent<MeshFilter>().mesh = ballSelection[randomBall];
    }

    [PunRPC]
    public void SetCameraActive()
    {
        playerCam.gameObject.SetActive(true);
    }

    
}
