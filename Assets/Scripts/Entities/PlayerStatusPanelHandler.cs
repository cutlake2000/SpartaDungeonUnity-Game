using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatusPanelHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI playerAtk;

    [SerializeField]
    private TextMeshProUGUI playerDef;

    [SerializeField]
    private TextMeshProUGUI playerHp;

    [SerializeField]
    private TextMeshProUGUI playerCtk;

    void Awake()
    {
        playerAtk = playerAtk.GetComponent<TextMeshProUGUI>();
        playerDef = playerDef.GetComponent<TextMeshProUGUI>();
        playerHp = playerHp.GetComponent<TextMeshProUGUI>();
        playerCtk = playerCtk.GetComponent<TextMeshProUGUI>();
    }

    public void SetPlayerStatusPanel(float atk, float def, float hp, float ctk)
    {
        WritePlayerAtk(atk);
        WritePlayerDef(def);
        WritePlayerHp(hp);
        WritePlayerCtk(ctk);
    }

    private void WritePlayerAtk(float atk)
    {
        playerAtk.text = atk.ToString();
    }

    private void WritePlayerDef(float def)
    {
        playerDef.text = def.ToString();
    }

    private void WritePlayerHp(float hp)
    {
        playerHp.text = hp.ToString();
    }

    private void WritePlayerCtk(float ctk)
    {
        playerCtk.text = ctk.ToString();
    }
}
