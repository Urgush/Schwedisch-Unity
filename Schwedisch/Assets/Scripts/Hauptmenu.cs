using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hauptmenu : MonoBehaviour
{
    public void TestSQLite ()
    {
        SceneManager.LoadScene("TestSQLiteScene");
    }

    public void Beenden()
    {
        Application.Quit();
    }

}
