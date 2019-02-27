using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class NetWorkObjects : MonoBehaviour
{
    public GolfCourse manager;

    // keep track of all the players in the game
    [HideInInspector] public List<PhotonView> players = new List<PhotonView>();

    public static NetWorkObjects find;

    int seed; // only matters on the master client

    // singleton assignment
    void Awake()
    {
        find = this;
    
        Transform spawnLocation = manager.startingSpots[Random.Range(0, manager.startingSpots.Length)];
        Vector3 spawnPos = spawnLocation.position;
        Quaternion spawnRot = spawnLocation.rotation;
        PhotonNetwork.Instantiate("Player", spawnPos, spawnRot, 0);
    }

    public void AddPlayer(PhotonView player)
    {
        // add a player to the list of all tracked players
        players.Add(player);

        // only the "server" has authority over which color the player should be and its seed
        if (PhotonNetwork.IsMasterClient)
        {
            player.RPC("SetColor", RpcTarget.AllBuffered, players.Count - 1); // buffer the color change so it applies to new arrivals in the room
            player.RPC("SetRandomSeed", RpcTarget.AllBuffered, seed);
        }
    }
}
