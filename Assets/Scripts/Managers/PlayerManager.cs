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

    private void Start()
    {
        UIManager.instance.UpdateValues(players[0], players[1]);
    }

    private void DamagePlayer(int id, int damage)
    {
        Player player = FindPlayerById(id);
        player.health -= damage;
        if (player.health <= 0)
        {
            PlayerLost(id);
        }
    }

    private void PlayerLost(int id)
    {
        UIManager.instance.GameFinished(id==0 ? FindPlayerById(1) : FindPlayerById(0));
    }

    public void AssignTurn(int currentPlayerTurn)
    {
        foreach (Player player in players)
        {
            player.myTurn = player.id == currentPlayerTurn;
        }
    }

    public Player FindPlayerById(int id)
    {
        Player player = players.Find(x => x.id == id);
        return player;
    }
}
