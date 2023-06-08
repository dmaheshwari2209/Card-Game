using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEndUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI winnerName;
    [SerializeField] private Button restart, quit;

    private void Awake()
    {
        // SetupButtons();
    }

    public void Initialize(Player winner)
    {
        winnerName.text = "Player: " + winner.id + " has won!";
    }
}
