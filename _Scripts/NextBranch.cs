using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextBranch : MonoBehaviour {
    private _Globals.Call call = new _Globals.Call();
    public void Advance() {
        _Globals.branchesCompleted++;
        call.DetermineCurrentIndex();
        _Globals.completedBranches.Add(_Globals.currentSceneIndex, _Globals.currentSceneIndex);
        call.GenerateNextBranch();
        SceneManager.LoadScene(_Globals.nextBranch);
    }
}
