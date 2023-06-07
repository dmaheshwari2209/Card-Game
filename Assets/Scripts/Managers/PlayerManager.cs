using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public List<Player> players = new List<Player>();

    private void Awake()
    {
        instance = this;
    }

    public void AssignTurn(int currentPlayerTurn)
    {
        Player player = players.Find(x => x.id == currentPlayerTurn);
        player.myTurn = true;
    }
}
