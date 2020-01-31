using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject player1Selected;
    public GameObject player2Selected;
    
    public Vector2Int uiPosition;

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