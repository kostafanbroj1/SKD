using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CS1 : MonoBehaviour
{

    public void GoToSceneOne(){
        SceneManager.LoadScene("SceneOne");
    }
}
