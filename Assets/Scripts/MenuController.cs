using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Lvl1()
    {
        SceneManager.LoadScene(1);
    }
    public void Lvl2()
    {
        SceneManager.LoadScene(2);
    }
}