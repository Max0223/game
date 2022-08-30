using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _endGameText;
    
    public void ShowGameEndScreen()
    {
        _endGameText.SetActive(true);
    }
}
