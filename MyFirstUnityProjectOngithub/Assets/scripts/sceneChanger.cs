using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadSceneOne()
    {
        SceneManager.LoadScene(1);
    }
    public void loadSceneTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void loadSceneThree()
    {
        SceneManager.LoadScene(3);
    }
    public void loadSceneMain()
    {
        SceneManager.LoadScene(0);
       
    }
}