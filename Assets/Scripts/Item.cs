using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [Range(0, 100)]
    public int weight;
    [Range(0, 100)]
    public float amount;

    public float secondsToPull;
    
    public GameObject player1Selected;
    public GameObject player2Selected;

    public void DePicked(int playerIndex)
    {
        if (playerIndex == 0)
        {
            player1Selected.SetActive(false);
        }
        else
        {
            player2Selected.SetActive(false);
        }
    }

    public void Picked(int playerIndex)
    {
        if (playerIndex == 0)
        {
            player1Selected.SetActive(true);
        }
        else
        {
            player2Selected.SetActive(true);
        }
    }

    public abstract void TakeDamage(ref float amount);
    public abstract void DealDamage(ref float amount);

    public abstract void Equip(ref Robot robot);
    public abstract void UnEquip(ref Robot robot);
}