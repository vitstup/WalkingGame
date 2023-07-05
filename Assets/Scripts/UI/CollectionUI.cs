using TMPro;
using UnityEngine;

public class CollectionUI : MonoBehaviour
{
    [SerializeField] private Canvas collectionCanvas;
    [SerializeField] private TextMeshProUGUI collectionText;

    public void ShowCollectionUI(ICollectable collectable)
    {
        if (!collectionCanvas.gameObject.activeSelf) collectionCanvas.gameObject.SetActive(true);
        ChangeCollectionText(collectable.collectableName);
    }

    private void ChangeCollectionText(string text)
    {
        collectionText.text = "You can collect " + text;
    }

    public void HideCollectionUI()
    {
        collectionCanvas.gameObject.SetActive(false);
    }
}