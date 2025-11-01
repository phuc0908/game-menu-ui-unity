using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    public bool isGameMenuActive = true;
    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        GameMenu.enabled = isGameMenuActive;
        Title.text = "Welcome to the Game!";
        Message.text = "Press Continue to start playing or Restart to reset the game.";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Continue";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    void Update()
    {

    }

    public void NextScene()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void RestartSence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
