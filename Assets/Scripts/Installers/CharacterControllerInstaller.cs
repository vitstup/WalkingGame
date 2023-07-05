using UnityEngine;
using Zenject;

public class CharacterControllerInstaller : MonoInstaller
{
    [SerializeField] private CharacterController characterController;

    public override void InstallBindings()
    {
        Container.Bind<CharacterController>().FromComponentInHierarchy(characterController).AsSingle().NonLazy();
    }
}