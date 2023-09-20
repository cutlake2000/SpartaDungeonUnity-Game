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
    private GameObject buttonPanel;

    [SerializeField]
    public GameObject statusPanel;

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
    }

    public void TurnOnStatusPanel()
    {
        buttonPanel.SetActive(false);
        statusPanel.SetActive(true);
    }

    public void TurnOffStatusPanel()
    {
        statusPanel.SetActive(false);
        buttonPanel.SetActive(true);
    }
}
