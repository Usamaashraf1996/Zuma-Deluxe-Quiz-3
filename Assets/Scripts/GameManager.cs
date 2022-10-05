using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] Prefab;
    public List<GameObject> enemyPrefab;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public float currentTime = 0;
    private float startTime = 15;
    private Rigidbody rb;
    public int random;
    private float time = 1f;
    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Instaniate();

        GameOver();
    }
    IEnumerator SpawnTarget() //For spawn enemy
    {
        while (isGameOver == false)
        {
            yield return new WaitForSeconds(time);
            int index = Random.Range(0, enemyPrefab.Count);
            Instantiate(enemyPrefab[index]);

        }
    }
    void GameOver()                //Timer funtion 
    {
        timer.text = "Timer " + currentTime.ToString("0");
        if (currentTime <= 0)
        {
            isGameOver = true;
            currentTime = 0;
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }

    }
    void Instaniate()
    {
        random = Random.Range(0, Prefab.Length);


        if (Input.GetKeyDown(KeyCode.Mouse0) && isGameOver == false)//Mouse press function
        {


            if (random == 0)
            {
                Instantiate(Prefab[random], PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            }
            if (random == 1)
            {
                Instantiate(Prefab[random], PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            }
            if (random == 2)
            {
                Instantiate(Prefab[random], PlayerController.instance.transform.position, PlayerController.instance.transform.rotation);
            }
        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


