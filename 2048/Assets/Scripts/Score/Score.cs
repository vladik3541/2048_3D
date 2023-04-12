using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestDraftingText;
    private int bestDrafting;

    private void Update()
    {
        TranslateBestDrafting();
    }

    private void TranslateBestDrafting() {
        if(PlayerPrefs.HasKey("bestDrafting"))
            bestDrafting = PlayerPrefs.GetInt("bestDrafting");

        bestDraftingText.text = bestDrafting.ToString();
    }
}
