using UnityEngine;
using UnityEngine.UI;

public class EquipmentPanel: MonoBehaviour {
    [SerializeField] Player player;
    [SerializeField] Image prankImage;
    [SerializeField] Image scoreImage;
    [SerializeField]  

    private void Start() {
        UpdateVisual();

        player.OnPrankItemChanged += (sender, e) => UpdateVisual();
        player.OnScoreItemChanged += (sender, e) => UpdateVisual();

    }
    public void UpdateVisual() {
        if (player == null)
            return;
        prankImage.sprite = player.GetScoreItemSO()?.itemSprite;
        scoreImage.sprite = player.GetPrankItemSO()?.itemSprite;

        prankImage.gameObject.SetActive(prankImage.sprite != null);
        scoreImage.gameObject.SetActive(scoreImage.sprite != null);
    }
}