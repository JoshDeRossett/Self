using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayCurrent : MonoBehaviour {
    [SerializeField]
    private Text nameDisplay;
	private void Start () { nameDisplay.text = gameObject.name; }
}
