using UnityEngine;
using System.Collections;

public class BranchContinue : MonoBehaviour {
    [SerializeField]
    private GameObject current;
    [SerializeField]
    private GameObject next;
    public void Next() {
        current.SetActive(false);
        next.SetActive(true);
    }
}
