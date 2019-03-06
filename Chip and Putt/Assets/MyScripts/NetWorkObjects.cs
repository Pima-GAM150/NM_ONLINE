using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class NetWorkObjects : MonoBehaviour
{
    public GolfCourse manager;
    Transform spawnLocation;
    int startingTee;

    // keep track of all the players in the game
    [HideInInspector] public List<PhotonView> players = new List<PhotonView>();

    public static NetWorkObjects find;

    int seed; // only matters on the master client

    // singleton assignment
    void Awake()
    {
        find = this;

        startingTee = Random.Range(0, manager.startingSpots.Length);


        spawnLocation = manager.startingSpots[startingTee];
        Vector3 spawnPos = spawnLocation.position;
        Quaternion spawnRot = spawnLocation.rotation;
        PhotonNetwork.Instantiate("Player", spawnPos, spawnRot, 0);
    }

    public void AddPlayer(PhotonView player)
    {
        // add a player to the list of all tracked players
        players.Add(player);

        // only the "server" has authority over which color the player should be and its seed
        //if (PhotonNetwork.IsMasterClient)
       // {

         

        if (PhotonNetwork.IsMasterClient)
        {
            player.GetComponentInChildren<GolfPlayer>().currentHole = startingTee;
            player.RPC("SetColor", RpcTarget.AllBuffered); // buffer the color change so it applies to new arrivals in the room
            player.RPC("SetCameraActive", RpcTarget.);
            
        }



    }
}
