using UnityEngine;
using UnityEngine.UI;

public class InputMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject inputMenu;
    [SerializeField] private Button back;

    void Update()
    {

        back.onClick.AddListener(BackAction);
        
    }

    void BackAction()
    {
        inputMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
