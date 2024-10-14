using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton:MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void CharacterSelectScene()
    {
        SceneManager.LoadScene("CharacterSelectScene");
    }

    public void MainScene()
    {
        //input.PlayerInputNameSave();
        //SceneManager.LoadScene("MainScene");
    }
}