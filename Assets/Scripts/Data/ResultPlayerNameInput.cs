using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ResultPlayerNameInput :MonoBehaviour
{
    [SerializeField] private TMP_InputField playerinputName;
    public Button button;

    public bool isBtn;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerinputName.GetComponentInChildren<TMP_InputField>().text;
    }

    private void Start()
    {
        button = GetComponentInChildren<Button>();

        switch(button.interactable)
        {
            case true:
                isBtn = true;
                break;
            case false:
                isBtn = false;
                break;
        }
    }

    // ÀúÀå
    public void PlayerInputNameSave()
    {
        if(playerinputName.text.Length > 1 && playerinputName.text.Length < 10)
        {
            isBtn = true;
            playerName = playerinputName.text;
            GameManager.instance.CurrentPlayerNameSave(playerName);
            MainLoadScene();
        }
        else
        {
            isBtn=false;
        }
    }

    public void MainLoadScene()
    {
        SceneManager.LoadScene("MainScene");

    }
}