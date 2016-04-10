using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextBranch : MonoBehaviour {
    private _Globals.Call call = new _Globals.Call();
    private GameObject warning;
    private void Awake() {
        warning = GameObject.FindGameObjectWithTag("Warning");
        warning.SetActive(!call.proceed);
    }
    public void Advance() {
        if (!call.proceed) return;
        _Globals.branchesCompleted++;
        call.DetermineCurrentIndex();
        call.UpdateCompletedBranches();
        call.GenerateNextBranch();
        call.ErrorCheck();
        warning.SetActive(!call.proceed);
        if (call.proceed) SceneManager.LoadScene(_Globals.nextBranch);
    }
}
