using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button renameBtn;
    [SerializeField] private Button selectBtn;
    [SerializeField] private TMP_InputField inputField;

    public ReSpawn reSpawn;
    private string changeName = null;

    public void Start()
    {
        selectBtn = GetComponentInChildren<Button>();
        changeName = GetComponentInChildren<TMP_InputField>().text;
    }

    public void Name()
    {

        if (inputField.text.Length > 1 && inputField.text.Length < 10)
        {
            selectBtn.interactable = true;
            changeName = inputField.text;
            GameManager.instance.CurrentPlayerNameSave(changeName);
            reSpawn.player.GetComponentInChildren<TextMeshPro>().text = changeName;
            OffDisplayPanel();  
        }
        else
        {
            selectBtn.interactable = false;
        }
    }

    public void DisplayPanel()
    {
        panel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void OffDisplayPanel()
    {
        Debug.Log(changeName);
        panel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}