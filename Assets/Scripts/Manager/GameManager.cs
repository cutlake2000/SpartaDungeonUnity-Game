using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public GameObject player;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
