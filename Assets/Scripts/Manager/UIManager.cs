using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject playerPanel;

    [SerializeField]
    private GameObject buttonPanel;

    [SerializeField]
    private GameObject statusPanel;

    private CharacterStatsHandler characterStatsHandler;
    private PlayerInfoPanelHandler playerInfoPanelHandler;
    private PlayerStatusPanelHandler playerStatusPanelHandler;
    private PlayerStatSO playerStatSO;

    private void Awake()
    {
        characterStatsHandler = player.GetComponent<CharacterStatsHandler>();
        playerInfoPanelHandler = playerPanel.GetComponent<PlayerInfoPanelHandler>();
        playerStatSO = characterStatsHandler.currentStats.playerStatSO;
    }

    private void Start()
    {
        SetPlayerInfo();
    }

    private void SetPlayerInfo()
    {
        playerInfoPanelHandler.SetPlayerInfoPanel(
            playerStatSO.lvValue,
            playerStatSO.expValue,
            playerStatSO.maxExpValue,
            playerStatSO.gold
        );
    }

    private void SetPlayerStatus()
    {
        statusPanel.SetActive(true);

        playerStatusPanelHandler.SetPlayerStatusPanel(
            playerStatSO.atkValue,
            playerStatSO.defValue,
            playerStatSO.hpValue,
            playerStatSO.ctkValue
        );
    }

    public void TurnOnStatusPanel()
    {
        buttonPanel.SetActive(false);

        SetPlayerStatus();
    }

    public void TurnOffStatusPanel()
    {
        statusPanel.SetActive(false);
        buttonPanel.SetActive(true);
    }
}
