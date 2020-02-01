using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public int indexSelected;
    public int previouslySelected;
    public List<Item> items;

    public GameObject walletPrefab;

    public void GoUp()
    {
        if (indexSelected + 1 != items.Count)
        {
            previouslySelected = indexSelected;
            indexSelected++;
            
            UpdateSelection();
        }
    }
    
    public void GoDown()
    {
        if (indexSelected - 1 != -1)
        {
            previouslySelected = indexSelected;
            indexSelected--;
            
            UpdateSelection();
        }
    }

    public void UpdateSelection()
    {
        transform.GetChild(previouslySelected).GetComponent<Image>().color = Color.white;
        transform.GetChild(indexSelected).GetComponent<Image>().color = Color.green;
    }
    
    public void AddToWallet(Item toAdd)
    {
        toAdd.gameObject.SetActive(false);
        var item = Instantiate(walletPrefab, transform);
        item.GetComponent<Image>().sprite = toAdd.GetComponent<SpriteRenderer>().sprite;
        
        items.Add(toAdd);
    }
    
    //TODO: rework this, beware of the ref
    public void RemoveElement(Item toRemove)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<Item>() == toRemove)
            {
                print("found");
                toRemove.gameObject.SetActive(true);
                items.Remove(toRemove);
                Destroy(transform.GetChild(i).gameObject);
                break;
            }
        }
    }

    public void RemoveElement()
    {
        print("removing");
        RemoveElement(items[indexSelected]);
    }

    public void DeSelect()
    {
        transform.GetChild(indexSelected).GetComponent<Image>().color = Color.white;
    }
}
