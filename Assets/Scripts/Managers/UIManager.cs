using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private TextMeshProUGUI player0Health, player1Health, player0Mana, player1Mana;
    private GameEndUIController gameEndUI;

    private void Awake()
    {
        instance = this;
    }

    public void GameFinished(Player winner)
    {
        gameEndUI.gameObject.SetActive(true);
        gameEndUI.Initialize(winner);
    }

    public void UpdateValues(Player player0, Player player1)
    {
        UpdateHealthValues(player0.health, player1.health);
        UpdateManaValues(player0.mana, player1.mana);
    }

    private void UpdateHealthValues(int player0Health, int player1Health)
    {
        this.player0Health.text = player0Health.ToString();
        this.player1Health.text = player1Health.ToString();
    }

    private void UpdateManaValues(int player0Mana, int player1Mana)
    {
        this.player0Mana.text = player0Mana.ToString();
        this.player1Mana.text = player1Mana.ToString();
    }
}
