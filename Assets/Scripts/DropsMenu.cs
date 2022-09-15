using UnityEngine;
using UnityEngine.UI;

public class DropsMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject dropMenu;
    [SerializeField] private Button back;
    [SerializeField] private Text subTitle;
    [SerializeField] private Dropdown dropdown;

    private void Start()
    {
        subTitle.text = "Next text";
        dropdown.onValueChanged.AddListener(delegate
        {
            DropDownValue(dropdown);
        });
    }

    void Update()
    {
        back.onClick.AddListener(BackActive);
    }

    void BackActive()
    {
        dropMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    void DropDownValue(Dropdown option)
    {
        if(option.value == 0)
        {
            subTitle.text = "Option A";
        }
        else if(option.value == 1)
        {
            subTitle.text = "Option B";
        }
        else if (option.value == 2)
        {
            subTitle.text = "Option C";
        }
        else if (option.value == 3)
        {
            subTitle.text = "Option D";
        }
    }
}
