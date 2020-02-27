using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answers : MonoBehaviour
{
    [SerializeField] bool answer = false;
    [SerializeField] GameObject Lose;
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void Anser()
    {
        if (answer)
        {
            StartCoroutine(KirKhar());
        }

        else
        {
            Lose.SetActive(true);
            StartCoroutine(KirKhar());
        }
    }

    IEnumerator KirKhar()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
