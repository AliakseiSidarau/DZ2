using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;

    [SerializeField] private Button buttonsButton;
    [SerializeField] private GameObject buttonsMenu;

    [SerializeField] private Button togglesButton;
    [SerializeField] private GameObject togglesMenu;

    [SerializeField] private Button dropsButton;
    [SerializeField] private GameObject dropsMenu;

    [SerializeField] private Button inputButton;
    [SerializeField] private GameObject inputMenu;

    [SerializeField] private Button scrollButton;
    [SerializeField] private GameObject scrollMenu;

    void Start()
    {
        mainMenu.SetActive(true);
    }

    void FixedUpdate()
    {
        buttonsButton.onClick.AddListener(ButtonsActive);
        togglesButton.onClick.AddListener(TogglesActive);
        dropsButton.onClick.AddListener(DropsActive);
        inputButton.onClick.AddListener(InputActive);
        scrollButton.onClick.AddListener(ScrollActive);
    }

    void ButtonsActive()
    {
        mainMenu.SetActive(false);
        buttonsMenu.SetActive(true);
    }

    void TogglesActive()
    {
        mainMenu.SetActive(false);
        togglesMenu.SetActive(true);
    }

    void DropsActive()
    {
        mainMenu.SetActive(false);
        dropsMenu.SetActive(true);
    }

    void InputActive()
    {
        mainMenu.SetActive(false);
        inputMenu.SetActive(true);
    }

    void ScrollActive()
    {
        mainMenu.SetActive(false);
        scrollMenu.SetActive(true);
    }
}
