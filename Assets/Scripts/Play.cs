using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject play;
    // Start is called before the first frame update
    public void Press_Jouer()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
