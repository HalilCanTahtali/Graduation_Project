using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public void Play_Button()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit_Button()
    {
        Application.Quit();
    }
    public void Settings_Button()
    {
        SceneManager.LoadScene(1);
    }
    public void Zihinsel_Engel_Button()
    {
        SceneManager.LoadScene(3);
    }
    public void Zihinsel_Engel_Oyun1_Button()
    {
        SceneManager.LoadScene(4);
    }
    public void Oyun_Secim_Geri()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings_Geri()
    {
        SceneManager.LoadScene(0);
    }
    public void Engel_Secim_Geri()
    {
        SceneManager.LoadScene(0);
    }
}
