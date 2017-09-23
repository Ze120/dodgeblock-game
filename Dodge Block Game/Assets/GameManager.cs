using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float slowDownFactor = 10f;

    public void EndGame () {

        StartCoroutine(RestartLevel());

    }

    IEnumerator RestartLevel () {

        // Slow down the time with variable "slowDownFactor" time
        Time.timeScale = 1f / slowDownFactor;
        //Fix Time.fixedDeltaTime get the same scale time what we modify
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;

        yield return new WaitForSeconds(1f / slowDownFactor);

        // Set the time back to regular time
        Time.timeScale = 1f;
        // Set Time.fixedDeltaTime back to regular time
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
