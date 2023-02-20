using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponge : Hand
{

    public int[] win;
    public int[] lose;

    public void Start()
    {
        win = new int[7];
        lose = new int[7];
        win[0] = gun;
        win[1] = lighting;
        win[2] = devil;
        win[3] = dragon;
        win[4] = water;
        win[5] = air;
        win[6] = paper;
        lose[0] = wolf;
        lose[1] = tree;
        lose[2] = human;
        lose[3] = snake;
        lose[4] = scissors;
        lose[5] = fire;
        lose[6] = rock;
    }
}
