using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public GameObject player;

    public ItemData itemData1;
    public ItemData itemData2;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        player.GetComponent<PlayerInventory>().AddItem(itemData1);
        player.GetComponent<PlayerInventory>().AddItem(itemData2);
    }
}
