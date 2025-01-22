using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text gasText;  
    [SerializeField] private GameObject gameOverPanel;  
    [SerializeField] private GameObject gameStartPanel;  

    private float currentGas = 100f;
    private float useGas = 10f;

    void Start()
    {
        gameStartPanel.SetActive(true);  
        gameOverPanel.SetActive(false);  
        Time.timeScale = 0f; 
    }

    void Update()
    {
        if (currentGas > 0)
        {
            Gas(); 
        }
    }

    public void StartGame()
    {
        currentGas = 100f;  
        gameStartPanel.SetActive(false);  
        Time.timeScale = 1f; 
    }

    public void Gas()
    {
        currentGas -= useGas * Time.deltaTime;
        if (currentGas <= 0f)
        {
            currentGas = 0f;
            EndGame(); 
        }

        gasText.text = "Gas: " + currentGas.ToString("F2");  
    }

    public void IncreaseGas(float amount)
    {
        currentGas += amount;
        gasText.text = "Gas: " + currentGas.ToString("F2");  
    }

    public void EndGame()
    {
        gameOverPanel.SetActive(true);  
        Time.timeScale = 0f;  
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}