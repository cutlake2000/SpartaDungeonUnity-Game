using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ButtonPanel;

    [SerializeField]
    private GameObject StatusPanel;

    [SerializeField]
    private TextMeshProUGUI playerLevel;

    [SerializeField]
    private TextMeshProUGUI playerExp;

    [SerializeField]
    private TextMeshProUGUI playerAtk;

    [SerializeField]
    private TextMeshProUGUI playerDef;

    [SerializeField]
    private TextMeshProUGUI playerHp;

    [SerializeField]
    private TextMeshProUGUI playerCtk;

    private void Awake() { }

    public void TurnOnStatusPanel()
    {
        ButtonPanel.SetActive(false);
        StatusPanel.SetActive(true);
    }

    public void TurnOffStatusPanel()
    {
        StatusPanel.SetActive(false);
        ButtonPanel.SetActive(true);
    }
}
