using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    private Unit playerUnit;
    private Unit enemyUnit;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;
    
    public BattleState state;

    void Start()
    {
        state = BattleState.START;
    }

    void SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab);
        playerGO.GetComponent<Unit>();
        
        GameObject enemyGO = Instantiate(enemyPrefab);
        enemyGO.GetComponent<Unit>();
        
        playerHUD.SetHUD(playerUnit);
        enemyHUD.SetHUD(enemyUnit);
    }
}
