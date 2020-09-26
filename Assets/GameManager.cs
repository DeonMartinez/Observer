using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    bool gameOver = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    //half way marker text
    public Text halfWayText;

    private void OnEnable()
    {
        PlayerMovement.OnHalfWay += DisplayText;
    }

    private void OnDisable()
    {
        PlayerMovement.OnHalfWay -= DisplayText;
    }
    public void CompleteLevel()
    { 
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameOver == false) {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DisplayText()
    {
        halfWayText.text = "You're Doing Great";
    }
}
