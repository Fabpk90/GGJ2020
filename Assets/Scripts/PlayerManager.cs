﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public int playerIndex;
    public PlayerInput input;

    public List<UISelector> selectObjects;

    public int selectedX, selectedY;

    public Vector2Int maxIndexUI;
    public Vector2Int minIndexUI;

    public Item itemInHand;

    public Robot robot;

    public float cooldownPick;
    public Wallet wallet;
    
    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
        input.SwitchCurrentActionMap("SelectionPart");
        
        input.currentActionMap["Direction"].started += OnDirection;
        input.currentActionMap["Selection"].started += OnSelection;
        
        input.SwitchCurrentActionMap("SelectionWallet");
        
        input.currentActionMap["Direction"].started += OnDirectionWallet;
        input.currentActionMap["Selection"].started += OnSelectionWallet;
    }

    private void OnSelectionWallet(InputAction.CallbackContext obj)
    {
       wallet.RemoveElement();
    }

    private void OnDirectionWallet(InputAction.CallbackContext obj)
    {
        var dir = obj.ReadValue<Vector2>();
        
        if (dir.x > 0)
        {
            if (playerIndex == 0)
            {
                selectedX = 0;
                selectedY = 0;
                
                input.SwitchCurrentActionMap("SelectionPart");
            }
        }
        else if (dir.x < 0)
        {
            if (playerIndex == 1)
            {
                selectedX = 0;
                selectedY = 0;
                
                input.SwitchCurrentActionMap("SelectionPart");
            }
        }
        
        if (dir.y > 0)
        {
            wallet.GoUp();
        }
        else if (dir.y < 0)
        {
            wallet.GoDown();
        }
    }

    private void OnSelection(InputAction.CallbackContext obj)
    {
        if (!GameManager.Instance.choosingPhase.activeSelf 
            || cooldownPick > Time.time)
            return;

        if (itemInHand != null)
        {
            print("yes");
            cooldownPick = itemInHand.secondsToPull + Time.time;
            wallet.AddToWallet(itemInHand);
        }

    }

    public void UpdateObjectSelection()
    {
        selectObjects.AddRange(FindObjectsOfType<UISelector>());
        SearchSelectedItem();
    }

    private void OnDirection(InputAction.CallbackContext obj)
    {
        if (!GameManager.Instance.choosingPhase.activeSelf 
        || cooldownPick > Time.time)
            return;
        var dir = obj.ReadValue<Vector2>();

        if (dir.x > 0)
        {
            if (selectedX + 1 <= maxIndexUI.x)
            {
                selectedX++;
            }
            //if it's player 2, goes to his wallet
            if (playerIndex == 1 && wallet.items.Count != 0)
            {
                input.SwitchCurrentActionMap("SelectionWallet");
                wallet.UpdateSelection();
            }
        }
        else if (dir.x < 0)
        {
            if (selectedX - 1 >= minIndexUI.x)
            {
                selectedX--;
            }
            else
            {
                //if it's player 1, goes to his wallet
                if (playerIndex == 0  && wallet.items.Count != 0)
                {
                    input.SwitchCurrentActionMap("SelectionWallet");
                    wallet.UpdateSelection();
                }
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

        SearchSelectedItem();
    }

    private void SearchSelectedItem()
    {
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
}
