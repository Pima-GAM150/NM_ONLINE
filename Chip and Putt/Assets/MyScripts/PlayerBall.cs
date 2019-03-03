using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerBall : MonoBehaviour
{

    public Mesh[] ballSelection;
    public GameObject currentball;
    public Camera playerCam;

    int randomBall;

    public void Awake()
    {
        randomBall = Random.Range(0, ballSelection.Length);
        currentball.GetComponent<MeshFilter>().mesh = ballSelection[randomBall];
        

    }
}
