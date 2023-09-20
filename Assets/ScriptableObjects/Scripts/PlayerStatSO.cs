using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "DefaultPlayerStatData",
    menuName = "StatController/Player/default",
    order = 0
)]
public class PlayerStatSO : ScriptableObject
{
    [Header("Player Info")]
    public int level;
    public float expValue;

    [Header("Player Stat")]
    public float atkValue;
    public float defValue;
    public float hpValue;
    public float ctkValue;
}
