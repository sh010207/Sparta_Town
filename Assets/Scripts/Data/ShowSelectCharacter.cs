using UnityEngine;

public class ShowSelcetCharacter : MonoBehaviour
{
    [SerializeField] GameObject objFox;
    [SerializeField] GameObject objFlog;
    private void DisPlaySelectCharacter()
    {
        switch (GameManager.instance.currentPlayer)
        {
            case Players.Fox:            
                objFlog.SetActive(false);
                objFox.SetActive(true);
                break;
            case Players.Frog:
                objFox.SetActive(false);
                objFlog.SetActive(true);
                break;
        }
    }
    public void Start()
    {
        DisPlaySelectCharacter();
    }
}