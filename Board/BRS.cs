﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BRS : MonoBehaviour {
    private int _power = 1;
    private int _money = 2;

    public int GetPower => _power;
    public int GetMoney => _money;
    
    public void SetPower(int power) => _power = power;
    public void SetMoney(int money) => _money = money;
}