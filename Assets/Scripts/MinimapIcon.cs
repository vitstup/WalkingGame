using UnityEngine;

public class MinimapIcon : MonoBehaviour
{
    [SerializeField] private Sprite icon;
    [SerializeField] private float iconSize = 1f;

    private void Start()
    {
        var obj = new GameObject("MinimapIcon");

        obj.transform.SetParent(transform);

        obj.transform.localPosition = new Vector3(0, 50f, 0);

        obj.transform.localRotation = Quaternion.Euler(90f, 90f, 0f);

        var renderer = obj.AddComponent<SpriteRenderer>();

        renderer.sprite = icon;

        obj.transform.localScale = new Vector2(iconSize * 0.5f, iconSize * 0.5f);

        int layer = LayerMask.NameToLayer("MinimapIcon");
        obj.layer = layer;

        Destroy(this);
    }
}
