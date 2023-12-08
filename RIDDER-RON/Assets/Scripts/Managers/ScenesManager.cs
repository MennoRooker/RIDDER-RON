using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        Menu01,
        World01,
        Battle01
    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.World01.ToString());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Menu01.ToString());
    }

    public void LoadSceneOnIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
}
