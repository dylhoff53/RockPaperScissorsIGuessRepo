using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Hand
{

    public int[] win;
    public int[] lose;

    public void Start()
    {
        win = new int[7];
        lose = new int[7];
        win[0] = sponge;
        win[1] = wolf;
        win[2] = tree;
        win[3] = dragon;
        win[4] = water;
        win[5] = air;
        win[6] = paper;
        lose[0] = gun;
        lose[1] = lighting;
        lose[2] = devil;
        lose[3] = snake;
        lose[4] = scissors;
        lose[5] = fire;
        lose[6] = rock;
    }
}