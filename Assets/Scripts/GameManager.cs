using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreView;
    [SerializeField] private GameObject gameOverView;
    [SerializeField] private GameObject[] birds;

    private void Awake()
    {
        birds[0].SetActive(false);
        int randomIndex = Random.Range(0, birds.Length);
        birds[randomIndex].SetActive(true);
    }

    private int _score;

    public int Score
    {
        get => _score;
        set
        {
            scoreView.text = value.ToString();
            _score = value;
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {        
        SceneManager.LoadScene(0);
        
    }

    public void GameIsOver()
    {
        gameOverView.SetActive(true);
        Time.timeScale = 0;
    }
}
