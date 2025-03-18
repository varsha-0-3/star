using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=5f;
    public float rSpeed=100f;
    public CharacterController controller;
    void Start()
    {
        controller=GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float movex=Input.GetAxis("Horizontal");
        float movez=Input.GetAxis("Vertical");
        Vector3 mov= movex*Vector3.right+movez*Vector3.forward;
        controller.Move(mov*Time.deltaTime*speed);

        float mouse=Input.GetAxis("Mouse X");
        transform.Rotate(0f, mouse*rSpeed*Time.deltaTime,0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Destroy(gameObject);
            GameController.instance.updateScore();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public static int score=0;
    public Text display;
    public GameObject button;
    int maxScore=4;
    
    
    void Start()
    {
        if (SceneManager.GetActiveScene().name=="Level 2"){
            score=0;
            maxScore=6;
            display.text="Score:"+score;
        }
        if (instance==null){
            instance=this;
        }
        button.SetActive(false);
    }
    public void updateScore(){
        score++;
        display.text="Score:"+score;
    }
    void Update(){
        if (score==maxScore){
            Debug.Log("you have won!");
            display.text = "you have won!";
            button.SetActive(true);
        }
    }
    public void nextLevel(){
        SceneManager.LoadScene("Level 2");
    }
    
}

using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    public Text timerDisplay;  // Assign in Inspector
    [SerializeField] private float timeLeft = 300f; // 5 minutes

    void Update()
    {
        timeLeft -= Time.deltaTime;

        int seconds = Mathf.FloorToInt(timeLeft);  // Convert time to integer seconds
        timerDisplay.text = "Time Left: " + seconds.ToString() + "s";

        //int minutes = Mathf.FloorToInt(timeLeft / 60);
        //int seconds = Mathf.FloorToInt(timeLeft % 60);
        //timerDisplay.text = "Time Left: " + minutes.ToString("00") + ":" + seconds.ToString("00");

        if (timeLeft <= 0)
        {
            timerDisplay.text = "Time's Up!";
            enabled = false; // Stop the script
        }
    }
}
