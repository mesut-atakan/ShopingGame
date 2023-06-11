using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("The variable used to hold the player's total balance")]
    [SerializeField]
    private int playerMoney;

    public int _playerMoney { get { return playerMoney; }  set { playerMoney = value; } }




    /// <summary>
    /// Use this method to make any changes to the player's money!
    /// </summary>
    /// <param name="value">Enter the amount you want to add or subtract here!</param>
    public void MoneyChange(int value)
    {
        playerMoney += value;
    }
}
