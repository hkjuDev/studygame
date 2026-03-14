using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  
    public void GoToNextScene()
    {
   
        SceneManager.LoadScene(1);

        
    }

public void GoToNextScene2()
{

    SceneManager.LoadScene(0);


}
}
