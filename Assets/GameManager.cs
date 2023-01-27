using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    /// 1. Passer au niveau suivant quand le joueur a terminé le niveau
    /// => Stocker la progression du joueur
    private int _currentAnimalsCount = 3;
    public int CurrentAnimalsCount
    {
        get
        {
            return _currentAnimalsCount;
        }
        set
        {
            _currentAnimalsCount = value;
            _score.UpdateScore(_currentAnimalsCount);
        }
    }

    private Score _score;

    private void Awake()
    {
        // A : Je m'initialise
        _score = FindObjectOfType<Score>();

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    //private void Start()
    //{
    // B : J'intéragie avec les autres
    //}

    //public int GetTest()
    //{
    //    return _test;
    //}

    //public void SetTest(int value)
    //{
    //    _test = value;
    //}

    /// => TODO: Vérifier la condition de victoire
    /// Faire ce test lorsque le compteur est décrémenté

    private void LoadNextLevel()
    {
        /// Déterminer l'index de la scène actuelle
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }

    public void DecrementAnimalCount()
    {
        CurrentAnimalsCount--;

        if (_currentAnimalsCount <= 0)
        {
            LoadNextLevel();
        }
    }

    //public static void LogMessage(string message)
    //{
    //    Debug.Log(message);
    //}

    /// 2. Afficher la progression du joueur
    /// => Ajouter de l'UI
    /// => Modifier les valeurs de l'UI dynamiquement via un script dédié (UIManager)
}