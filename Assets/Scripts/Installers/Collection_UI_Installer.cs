using UnityEngine;
using Zenject;

public class Collection_UI_Installer : MonoInstaller
{
    [SerializeField] private CollectionUI collectionUI;

    public override void InstallBindings()
    {
        Container.Bind<CollectionUI>().FromComponentInHierarchy(collectionUI).AsSingle().NonLazy();
    }
}