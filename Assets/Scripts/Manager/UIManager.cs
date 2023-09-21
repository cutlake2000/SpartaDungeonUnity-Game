using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject playerPanel;

    [SerializeField]
    private GameObject menuPanel;

    [SerializeField]
    private GameObject buttonPanel;

    [SerializeField]
    public GameObject statusPanel;

    [SerializeField]
    public TextMeshProUGUI menuText;

    public CharacterStatsHandler characterStatsHandler;
    public PlayerStatSO playerStatSO;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Init();
    }

    private void Init()
    {
        characterStatsHandler = player.GetComponent<CharacterStatsHandler>();
        playerStatSO = characterStatsHandler.currentStats.playerStatSO;
        menuText = menuText.GetComponent<TextMeshProUGUI>();
    }

    public void TurnOnStatusPanel()
    {
SetMenuText(Menu.Status);
        buttonPanel.SetActive(false);
        statusPanel.SetActive(true);
    }

    public void TurnOffStatusPanel()
    {
        SetMenuText(Menu.Menu);
        statusPanel.SetActive(false);
        buttonPanel.SetActive(true);
    }

    private void SetMenuText(Menu menu){
        switch(menu){
              case Menu.Menu:
            menuText.text = "메뉴";
            break;
                      case Menu.Status:
            menuText.text = "상태창";
            break;
                      case Menu.Inventory:
            menuText.text = "인벤토리";
            break;
                      case Menu.Shop:
            menuText.text = "상점";
            break;
        }
    }

    private enum Menu{
        Menu,
        Status,
        Inventory,
        Shop
    }
}
