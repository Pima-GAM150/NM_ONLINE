using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraOperator : MonoBehaviourPun, IPunObservable
{

    //all player controls are in here

    public float moveSpeed;
    public float rotateSpeed;
    public GolfPlayer theBall;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    public void MoveCamera()
    {
       // if (photonView.IsMine)
       // {
            float horiz = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float vert = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float rotate = Input.GetAxis("Rotate") * Time.deltaTime * rotateSpeed;
            float elevation = Input.GetAxis("Elevation") * Time.deltaTime * moveSpeed;

            transform.Translate(horiz, elevation, vert);
            transform.Rotate(0, rotate, 0, 0);

        //}
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = new Vector3(theBall.gameObject.transform.position.x, theBall.gameObject.transform.position.y, theBall.gameObject.transform.position.z);
           
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            theBall.gameObject.transform.position = theBall.teeList.startingSpots[theBall.currentHole].transform.position;
        }


    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        throw new System.NotImplementedException();
    }
}
