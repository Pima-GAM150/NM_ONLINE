using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class Player : MonoBehaviourPun, IPunInstantiateMagicCallback
{
    public GameObject playerCam;

    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        NetWorkObjects.find.AddPlayer(this.photonView); // when the player is created, add it to a list of all players on the singleton

        

        if ( photonView.IsMine )
        {
            playerCam.SetActive(true);

            return;
        }
    }
}
