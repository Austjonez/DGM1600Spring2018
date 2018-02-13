using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ArraysAndLoops : MonoBehaviour {
    public int[] HighScores;
    public PowerUp[] Powerups;
	public Player[] Players;
    void Start () {
        foreach (var player in Players) {
            print (player.PlayerName);
			print (player.Score);
			print (player.MP);
        }
        foreach (var scores in HighScores) {
            if (scores >= 1000) {
                print (scores);
            }
        }

    }
}