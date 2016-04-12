using UnityEngine;
using System.Collections;

public class ChoiceDisplay : MonoBehaviour {
   public int _trait;
   private string t1;
   private string t2;
   private int traitvalue1;
   private int traitvalue2;
   private void Start() {
       DetermineTrait();
       gameObject.SetActive(IsDisplayed(t1, t2));
   }
   private bool IsDisplayed(string _trait1, string _trait2) {
       _Globals.trait.TryGetValue(_trait1, out traitvalue1);
       _Globals.trait.TryGetValue(_trait2, out traitvalue2);
       bool displayed = traitvalue1 > traitvalue2 ? true : false;
       return displayed;
   }
   private void DetermineTrait() {
       switch (_trait) {
           case 1:
           t1 = "introvert";
           t2 = "extrovert";
           break;
           case 2:
           t1 = "extrovert";
           t2 = "introvert";
           break;
           case 3:
           t1 = "practicle";
           t2 = "creative";
           break;
           case 4:
           t1 = "creative";
           t2 = "practicle";
           break;
           case 5:
           t1 = "logic";
           t2 = "emotion";
           break;
           case 6:
           t1 = "logic";
           t2 = "emotion";
           break;
           case 7:
           t1 = "order";
           t2 = "spontaneity";
           break;
           case 8:
           t1 = "spontaneity";
           t2 = "order";
           break;
       }
   }
}
