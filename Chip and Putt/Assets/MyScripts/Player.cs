using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class Player : MonoBehaviour, IPunInstantiateMagicCallback
{
    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        NetWorkObjects.find.AddPlayer(this.photonView); // when the player is created, add it to a list of all players on the singleton
    }
}
