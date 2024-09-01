
using UnityEngine;

public class Enlaces : MonoBehaviour
{

    public void OpenRedes(int ID)
    {
        string url = "";

        switch (ID)
        {
            case 1:
                url = "https://www.facebook.com";
                break;
            case 2:
                url = "https://www.twitter.com";
                break;
            case 3:
                url = "https://www.instagram.com";
                break;
            default:
                Debug.Log("ID no válido");
                return;
        }

        Application.OpenURL(url);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
