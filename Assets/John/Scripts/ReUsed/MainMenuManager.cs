using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject OptionsMenu;
  
    public GameObject PauseMenu;

    public void OnClickPlay()
    {
        SceneManager.LoadScene("MainLevels");
       
    }
   
    

    public void OnClickQuit()
    {
        SceneManager.LoadScene("John Beta");
    }

    public void OnClickPause()
    {
        PauseMenu.SetActive(true);
    }


}
