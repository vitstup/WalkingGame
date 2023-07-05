using UnityEngine;

public interface ICollectable
{
    public string collectableName { get; }
    public Sprite sprite { get; }

    public void Collected();
}