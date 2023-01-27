using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;

    /// TODO: Appeler cette méthode lorsque le compteur d'animaux est modifié
    public void UpdateScore(int Level)
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = $"NIV.{Level}";
    }
}
