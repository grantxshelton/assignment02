using UnityEngine;
using UnityEngine.UI;
public class Credits : MonoBehaviour
{
    public void Quit()
    {
        // exit the game for real play
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
