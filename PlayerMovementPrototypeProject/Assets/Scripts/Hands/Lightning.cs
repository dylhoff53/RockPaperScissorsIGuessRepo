using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Hand
{

    public int[] win;
    public int[] lose;

    public void Start()
    {
        win = new int[7];
        lose = new int[7];
        win[0] = fire;
        win[1] = scissors;
        win[2] = snake;
        win[3] = human;
        win[4] = tree;
        win[5] = gun;
        win[6] = rock;
        lose[0] = paper;
        lose[1] = air;
        lose[2] = water;
        lose[3] = dragon;
        lose[4] = devil;
        lose[5] = wolf;
        lose[6] = sponge;
    }
}
