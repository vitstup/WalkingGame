using UnityEngine;
using Zenject;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private InventorySlotUI[] slots;

    [Inject] private Inventory inventory;

    public void UpdateUI(ICollectable[] collectables)
    {
        if (collectables.Length > slots.Length) Debug.LogWarning("Slots UI to small to preview all items");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < collectables.Length) slots[i].SetSlot(collectables[i]);
            else slots[i].ClearSlot();
        }
    }

    public void Collect()
    {
        if (inventory.collectablePossibleForCollection == null)
        {
            Debug.Log("You're trying to collect thing in near radius, but that is not possible");
            return;
        }
        inventory.Collect();
    }
}
