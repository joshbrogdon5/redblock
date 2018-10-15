using UnityEngine;

public class Credits : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("Can't Quit While In Unity!");
        Application.Quit();
    }

}
