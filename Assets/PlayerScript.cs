/*RogueBoy*/
/*Aimi Watanabe*/

/*Player Script*/

using UnityEngine;
using UnityEditor;

class PlayerScript: MonoBehaviour
{
    private string thisTitle = "Welcome to RogueBoy!";
    private string thisCredits = "- Aimi Watanabe GAM655 -";
    private string[] thisInstructions =
        {
            "INSTRUCTIONS:",
            "Press the cursor keys to move.",
            "Press the space bar to shoot a weapon.",
            "Hold the space bar to keep shooting with a short cooldown.",
            "Press escape to quit.",
        };


    void Start()
    {
        print(thisTitle);
        print(thisCredits);
        foreach (string aInstruct in thisInstructions)
        {
            print(aInstruct);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            EditorApplication.isPlaying = false;
        }
    }
}