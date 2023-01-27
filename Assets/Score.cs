using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    private TextMeshProUGUI textComponent;

    private void Awake()
    {
        // A
        textComponent = scoreText.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(int animalsCount)
    {
        textComponent.text = $"Animals: {animalsCount}";
    }
}