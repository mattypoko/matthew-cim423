using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "" + score;
        if (score >= 10)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

}