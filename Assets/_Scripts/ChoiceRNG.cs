using UnityEngine;
using System.Collections;

public class ChoiceRNG : MonoBehaviour {
    private int simplifiedvalues;
	private void Start() {
        SimplifyTraitValues();
	    GenerateChoices();
	}
    private void GenerateChoices() {
        switch (simplifiedvalues)
        {
            case 1:
                DisplayExtrovertorIntrovert();
                break;
            case 2:
                DisplayPracticalorCreative();
                break;
            case 3:
                DisplayLogicorEmotion();
                break;
            case 4:
                DisplayOrderorSpontaneity();
                break;
            default: 
                DisplayAll();
                break;
        }
    }
    private void DisplayAll() {
        
    }
    private void SimplifyTraitValues() {
        
    }
    private void DisplayExtrovertorIntrovert() {
        
    }
    private void DisplayPracticalorCreative() {
        
    }
    private void DisplayLogicorEmotion() {
        
    }
    private void DisplayOrderorSpontaneity() {
        
    }
}
