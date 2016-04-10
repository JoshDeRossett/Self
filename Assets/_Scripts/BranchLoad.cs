using UnityEngine;
using System.Collections;

public class BranchLoad : MonoBehaviour {
    [SerializeField]
    private GameObject start;
    private void Start() { start.SetActive(true); }
}
