using UnityEngine;
using UnityEngine.UI;

public class ButtonsMenu : MonoBehaviour
{
    [SerializeField] private Button back;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject buttonsMenu;
    [SerializeField] private Button oneButton;
    [SerializeField] private Button twoButton;
    [SerializeField] private Button disableButton;
    [SerializeField] private Text subTitle;

    void Update()
    {
        oneButton.onClick.AddListener(OneActive);
        twoButton.onClick.AddListener(TwoActive);
        disableButton.onClick.AddListener(DisableActive);
        back.onClick.AddListener(BackActive);
    }

    void OneActive()
    {
        subTitle.text = "One clicked";
    }

    void TwoActive()
    {
        subTitle.text = "Two clicked";
    }

    void DisableActive()
    {

        oneButton.enabled = false;
        oneButton.interactable = false;
        twoButton.enabled = false;
        twoButton.interactable = false;
    }

    void BackActive()
    {
        buttonsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
