using UnityEngine;
using UnityEngine.UI;

public class TogglesMenu : MonoBehaviour
{
    [SerializeField] private GameObject togglesMenu;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Button back;
    [SerializeField] private Text subTitle;
    [SerializeField] private Toggle first;
    [SerializeField] private Toggle second;
    [SerializeField] private Toggle third;

    private void Start()
    {
        subTitle.text = "Next Text";
    }

    void Update()
    {
        back.onClick.AddListener(BackAction);

        first.onValueChanged.AddListener(delegate
        {
            FirstActive(first);
        });

        second.onValueChanged.AddListener(delegate
        {
            SecondActive(second);
        });

        third.onValueChanged.AddListener(delegate
        {
            ThirdActive(third);
        });

    }

    void BackAction()
    {
        togglesMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    void FirstActive(Toggle first)
    {
        if(first.isOn == true)
        {
            subTitle.text = "First";
        }
    }

    void SecondActive(Toggle second)
    {
        if(second.isOn == true)
        {
            subTitle.text = "Second";
        }
    }

    void ThirdActive(Toggle third)
    {
        if(third.isOn == true)
        {
            subTitle.text = "Third";
        }
    }
}
