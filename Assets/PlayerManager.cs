using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public int playerIndex;
    private PlayerInput input;

    public List<UISelector> selectObjects;

    public int selectedX, selectedY;

    public Vector2Int maxIndexUI;
    public Vector2Int minIndexUI;

    public Item itemInHand;
    
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        input.SwitchCurrentActionMap("Selection");
        
        input.currentActionMap["Direction"].started += OnDirection;
        selectObjects.AddRange(FindObjectsOfType<UISelector>());
        
      itemInHand = FindObjectAt(selectedX, selectedY).GetComponent<Item>();
      itemInHand.Picked(playerIndex);
    }

    private void OnDirection(InputAction.CallbackContext obj)
    {
        var dir = obj.ReadValue<Vector2>();

        if (dir.x > 0)
        {
            if (selectedX + 1 <= maxIndexUI.x)
            {
                selectedX++;
            }
        }
        else if (dir.x < 0)
        {
            if (selectedX - 1 >= minIndexUI.x)
            {
                selectedX--;
            }
        }
        
        if (dir.y > 0)
        {
            if (selectedY + 1 <= maxIndexUI.y)
            {
                selectedY++;
            }
        }
        else if (dir.y < 0)
        {
            if (selectedY - 1 >= minIndexUI.y)
            {
                selectedY--;
            }
        }

        var searchItem = FindObjectAt(selectedX, selectedY).GetComponent<Item>();

        if (itemInHand != null)
        {
            itemInHand.DePicked(playerIndex);
        }

        searchItem.Picked(playerIndex);
        itemInHand = searchItem;
    }

    UISelector FindObjectAt(int x, int y)
    {
        Vector2Int position = new Vector2Int(x, y);

        foreach (UISelector i in selectObjects)
        {
            if (i.position == position)
                return i;
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
