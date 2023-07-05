using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Image itemImage;

    private ICollectable collectable;

    public void SetSlot(ICollectable collectable)
    {
        this.collectable = collectable;
        itemImage.gameObject.SetActive(true);
        itemImage.sprite = collectable.sprite;
    }

    public void ClearSlot()
    {
        collectable = null;
        itemImage.gameObject.SetActive(false);
    }
}