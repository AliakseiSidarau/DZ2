using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject scrollMenu;
    [SerializeField] private Button back;

    void Start()
    {
        
    }

    void Update()
    {
        back.onClick.AddListener(BackActive);
    }

    void BackActive()
    {
        scrollMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
