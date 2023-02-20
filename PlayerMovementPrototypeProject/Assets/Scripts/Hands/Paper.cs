using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paper : Hand
{

    public int[] win;
    public int[] lose;

    public void Start()
    {
        win = new int[7];
        lose = new int[7];
        win[0] = air;
        win[1] = water;
        win[2] = dragon;
        win[3] = devil;
        win[4] = lighting;
        win[5] = gun;
        win[6] = rock;
        lose[0] = fire;
        lose[1] = scissors;
        lose[2] = snake;
        lose[3] = human;
        lose[4] = tree;
        lose[5] = wolf;
        lose[6] = sponge;
    }
}
