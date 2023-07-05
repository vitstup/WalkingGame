using UnityEngine;
using Zenject;

public class Item : MonoBehaviour, ICollectable
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite itemSprite;

    [Inject] private CollectionUI collectionUI;

    public Sprite sprite => itemSprite;

    public string collectableName => itemName;

    private Inventory inventory;

    public void Collected()
    {
        if (inventory.collectablePossibleForCollection == this as ICollectable) collectionUI.HideCollectionUI();
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            this.inventory = inventory;
            inventory.collectablePossibleForCollection = this;
            collectionUI.ShowCollectionUI(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Inventory inventory = other.GetComponent<Inventory>();
        if (inventory != null)
        {
            if (inventory.collectablePossibleForCollection == this as ICollectable)
            {
                collectionUI.HideCollectionUI();
                inventory.collectablePossibleForCollection = null;
            }
        }
    }
}
