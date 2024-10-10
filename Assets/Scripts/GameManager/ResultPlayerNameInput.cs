using UnityEngine;
using UnityEngine.UI;

public class ResultPlayerNameInput :MonoBehaviour
{
	public InputField inputName;
	private string playerName = null;

    private void Awake()
    {
        playerName = inputName.GetComponent<InputField>().text;
    }

    public void InputName()
	{
        playerName = inputName.text;
		PlayerPrefs.SetString("CurrentPlayerName", playerName);
	}

    private void Update()
    {
        if(playerName.Length > 0 &&  Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }

    private void Start()
    {
        Debug.Log(playerName);
    }
}