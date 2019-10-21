using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    [SerializeField]
    string sceneName;


    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }  
}
