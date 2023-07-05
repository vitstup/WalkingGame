using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Inventory : MonoBehaviour
{
    private List<ICollectable> items = new List<ICollectable>();
    public ICollectable collectablePossibleForCollection;

    [Inject] private InventoryUI inventoryUI;

    public void CollectItem(ICollectable item)
    {
        items.Add(item);

        inventoryUI.UpdateUI(items.ToArray());

        item.Collected();

        if (item == collectablePossibleForCollection) collectablePossibleForCollection = null;

        Debug.Log("Collected " +  item.collectableName);
    }

    public void Collect()
    {
        CollectItem(collectablePossibleForCollection);
    }

}
