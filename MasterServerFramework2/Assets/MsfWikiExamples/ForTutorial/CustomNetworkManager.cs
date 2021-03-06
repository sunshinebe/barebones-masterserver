﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomNetworkManager : NetworkManager
{

    public  void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        var player = Instantiate(playerPrefab);

        var customPlayer = playerPrefab.GetComponent<CustomPlayer>();
        customPlayer.UsernameMesh.text = "Random" + (int) (Random.value*100);

        NetworkServer.AddPlayerForConnection(conn, player.gameObject, System.Guid.Empty);

    }
}
