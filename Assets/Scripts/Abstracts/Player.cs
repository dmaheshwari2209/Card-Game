[System.Serializable]
public class Player
{
    public int health, mana;
    public int id;
    public bool myTurn;

    public Player(int health, int id, int mana)
    {
        this.health = health;
        this.id = id;
        this.mana = mana;
    }
}
