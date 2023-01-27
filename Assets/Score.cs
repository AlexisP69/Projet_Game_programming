using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;

    /// TODO: Appeler cette m�thode lorsque le compteur d'animaux est modifi�
    public void UpdateScore(int Level)
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = $"NIV.{Level}";
    }
}
