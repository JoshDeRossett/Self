using UnityEngine;
using System.Collections;

public class BranchContinue : MonoBehaviour {
    private GameObject current;
    [SerializeField]
    private GameObject next;
    private void Start() { current = gameObject; }
    public void Next() {
        current.SetActive(false);
        next.SetActive(true);
    }
}