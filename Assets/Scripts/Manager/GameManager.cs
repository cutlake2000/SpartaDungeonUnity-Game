using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public GameObject player;
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

    private void Start() { }

    private void Init()
    {
        characterStatsHandler = player.GetComponent<CharacterStatsHandler>();
        Debug.Log("GM - characterStatsHandler" + characterStatsHandler.name);
        playerStatSO = characterStatsHandler.currentStats.playerStatSO;
        Debug.Log("GM - playerStatSO" + playerStatSO.name);
    }
}
