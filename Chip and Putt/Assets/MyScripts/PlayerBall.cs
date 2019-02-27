using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{

    public Mesh[] ballSelection;
    public GameObject currentball;

    int randomBall;

    public void Awake()
    {
        randomBall = Random.Range(0, ballSelection.Length);
        currentball.GetComponent<MeshFilter>().mesh = ballSelection[randomBall];
    }
}
