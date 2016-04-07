using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class _Globals : MonoBehaviour {
    public static int nextBranch;
    public static int previousbranch;
    //Build Index Numbers = 0: Title Screen, 1-3: Act 1, 4-6: Act 2, 7-9: Act 3
    //Still Need - Prelude, End Cards
    public static int actNumber;
    public static int branchesCompleted = 0;
    public static int currentSceneIndex;
    public static Dictionary<string, int> trait = new Dictionary<string, int>();
    //Key = Build Index
    public static Dictionary<int, int> completedBranches = new Dictionary<int, int>();
    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }
    private void Start() {
        TraitDictionarySetUp();
    }
    private void TraitDictionarySetUp() {
        trait.Add("introvert", 0);
        trait.Add("extrovert", 0);

        trait.Add("practical", 0);
        trait.Add("creative", 0);

        trait.Add("logic", 0);
        trait.Add("emotion", 0);

        trait.Add("order", 0);
        trait.Add("spontaneity", 0);
    }
    public class Call {
        public void GenerateNextBranch() {
            //Act 1: Title + 2 Branches = 3, Act 2: + 2 More Branches = 5, Act 3: + 2 More Branches = 7
            actNumber = branchesCompleted <= 3 ? 1 : branchesCompleted <= 5 ? 2 : 3;
            //Random.Range Min = Inclusive, Max = Exclusive
            nextBranch = actNumber == 1 ? Random.Range(1, 4) : actNumber == 2 ? Random.Range(4, 7) : Random.Range(7, 10);
            print("Attempted Value: " + nextBranch);
            completedBranches.TryGetValue(nextBranch, out previousbranch);
            if (nextBranch == previousbranch) GenerateNextBranch();
            else print("Final Value: " + nextBranch);
        }
        public void DetermineCurrentIndex() {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        }
    }
}
