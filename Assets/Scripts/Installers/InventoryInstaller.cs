using UnityEngine;
using Zenject;

public class InventoryInstaller : MonoInstaller
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private InventoryUI inventoryUI;

    public override void InstallBindings()
    {
        Container.Bind<Inventory>().FromComponentInHierarchy(inventory).AsSingle().NonLazy();
        Container.Bind<InventoryUI>().FromComponentInHierarchy(inventoryUI).AsSingle().NonLazy();
    }
}