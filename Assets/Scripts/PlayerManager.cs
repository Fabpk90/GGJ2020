using System.Collections;
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

    public UISelector itemInHand;

    public float cooldownPick;
    public Wallet wallet;


    public PlayerFight playerFight;
    
    // Start is called before the first frame update
    void Start()
    {
        playerFight = GetComponent<PlayerFight>();
        
        input = GetComponent<PlayerInput>();
        input.SwitchCurrentActionMap("SelectionPart");
        
        input.currentActionMap["Direction"].started += OnDirection;
        input.currentActionMap["Selection"].started += OnSelection;
        
        input.SwitchCurrentActionMap("SelectionWallet");
        
        input.currentActionMap["Direction"].started += OnDirectionWallet;
        input.currentActionMap["Selection"].started += OnSelectionWallet;

        wallet.player = this;
        
        input.SwitchCurrentActionMap("Fight");
        
        input.currentActionMap["Weapon1"].started += OnWeapon1Used;
        input.currentActionMap["Weapon2"].started += OnWeapon2Used;
        input.currentActionMap["Direction"].started += OnDirectionFight;
        input.currentActionMap["Direction"].canceled += OnDirectionFight;
        input.currentActionMap["Jump"].started += OnJump;
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        playerFight.Jump();
    }

    private void OnDirectionFight(InputAction.CallbackContext obj)
    {
        playerFight.Move(obj.ReadValue<Vector2>());
    }

    private void OnWeapon2Used(InputAction.CallbackContext obj)
    {
        playerFight.UseWeapon1();
    }

    private void OnWeapon1Used(InputAction.CallbackContext obj)
    {
        playerFight.UseWeapon2();
    }

    private void OnSelectionWallet(InputAction.CallbackContext obj)
    {
       wallet.RemoveElement();
       selectedX = selectedY = 0;
    }

    private void OnDirectionWallet(InputAction.CallbackContext obj)
    {
        var dir = obj.ReadValue<Vector2>();
        
        if (dir.x > 0)
        {
            if (playerIndex == 0)
            {
                GoBackToSelection();
            }
        }
        else if (dir.x < 0)
        {
            if (playerIndex == 1)
            {
                GoBackToSelection();
            }
        }
        
        if (dir.y < 0)
        {
            wallet.GoUp();
        }
        else if (dir.y > 0)
        {
            wallet.GoDown();
        }
    }

    public void GoBackToSelection()
    {
        selectedX = 0;
        selectedY = 0;

        wallet.DeSelect();

        input.SwitchCurrentActionMap("SelectionPart");

        SearchSelectedItem();
    }

    private void OnSelection(InputAction.CallbackContext obj)
    {
        if (!GameManager.Instance.choosingPhase.activeSelf 
            || cooldownPick > Time.time)
            return;

        if (itemInHand != null && itemInHand.item != null && itemInHand.item.gameObject.activeSelf
            && !(selectedX == 0 && selectedY == 0))
        {
            cooldownPick = itemInHand.item.secondsToPull + Time.time;
            wallet.AddToWallet(itemInHand.item);

            selectedX = 0;
            selectedY = 0;
            
            SearchSelectedItem();
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
                if (!SearchSelectedItem())
                    selectedX--;
            }
            else if (playerIndex == 1 && wallet.items.Count != 0)
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
                if (!SearchSelectedItem())
                    selectedX++;
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
                if (!SearchSelectedItem())
                    selectedY--;
            }
        }
        else if (dir.y < 0)
        {
            if (selectedY - 1 >= minIndexUI.y)
            {
                selectedY--;
                if (!SearchSelectedItem())
                    selectedY++;
            }
        }

       
    }

    private bool SearchSelectedItem()
    {
        var searchItem = FindObjectAt(selectedX, selectedY);

        if (searchItem)
        {
            if (itemInHand != null)
            {
                itemInHand.DePicked(playerIndex);
            }

            searchItem.Picked(playerIndex);
            itemInHand = searchItem;

            return true;
        }

        return false;

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
