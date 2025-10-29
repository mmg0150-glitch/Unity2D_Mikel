using UnityEngine;
using UnityEngine.SceneManagement;
public class ControladorNivel1 : MonoBehaviour
{




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {

            SceneManager.LoadScene(1);

        }

        else if (Input.GetKeyDown(KeyCode.O))
        {

            SceneManager.LoadScene(0);

        }




    }
}
