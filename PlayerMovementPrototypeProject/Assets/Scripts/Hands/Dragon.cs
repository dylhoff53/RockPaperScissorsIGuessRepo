using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Hand
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
        win[3] = devil;
        win[4] = lighting;
        win[5] = gun;
        win[6] = rock;
        lose[0] = paper;
        lose[1] = air;
        lose[2] = water;
        lose[3] = human;
        lose[4] = tree;
        lose[5] = wolf;
        lose[6] = sponge;
    }
}
