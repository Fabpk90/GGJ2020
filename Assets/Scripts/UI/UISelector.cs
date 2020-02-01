using UnityEngine;
public class UISelector : MonoBehaviour
{
    public Vector2Int position;
    
    public GameObject player1Selected;
    public GameObject player2Selected;

    public Item item;

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
}