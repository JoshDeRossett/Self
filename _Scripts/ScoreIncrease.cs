using UnityEngine;
using System.Collections;

public class ScoreIncrease : MonoBehaviour {
    public void AddPoints(string trait) {
        _Globals.trait[trait]++;
    }
}
