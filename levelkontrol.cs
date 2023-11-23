sing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelkontrol : MonoBehaviour
{

    int kontrolid;


  public void kontrol()
    {
        if (PlayerPrefs.HasKey("kontrolid"))
        {
            kontrolid = PlayerPrefs.GetInt("kontrolid");
        }


        if (kontrolid == 0)

        {

            SceneManager.LoadScene("tutorial");

        }


        if (kontrolid == 1)

        {

            SceneManager.LoadScene("levels1");

        }

}
