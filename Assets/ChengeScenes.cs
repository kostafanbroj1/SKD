using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChengeScenes : MonoBehaviour
{

    public void GoToSceneTwo(){
        SceneManager.LoadScene("SceneTwo");
    }
}
