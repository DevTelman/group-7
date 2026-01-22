
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
   public float ForceAmout = 50f;
    public Rigidbody rb;
    int NewTag  = 0;
    public float Timer = 60;
   
    public int TargetNewTag;
    
    public  TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    bool GameOver;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    public AudioSource Music;
    public GameObject MagicPoof;

   
    // Start is callined once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        GameOver = false;
       ScoreText.text = NewTag.ToString() + "/" + TargetNewTag.ToString();
        
        WinScreen.SetActive(false);
       LoseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");

        float ver = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(hor, 0, ver) * ForceAmout;
        if (!GameOver)
        {


            rb.AddForce(force);
            Timer = Timer - Time.deltaTime;
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            rb.linearVelocity = Vector3.zero; 
        }
        TimerText.text = Timer.ToString();
        TimerText.text = ((int)Timer).ToString();
          if (Timer<=0&&!GameOver)
          {
            GameOver = true;
            LoseScreen.SetActive(true);
          }
    }
     void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.tag=="NewTag"&& !GameOver)
        {
            GameOver = true;
            print("You Lost");
            LoseScreen.SetActive(true);
        }
     }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NewTag")

        {
            Instantiate(MagicPoof, other.transform.position,new Quaternion());
            Destroy(other.gameObject);
            Music.Play();

            NewTag++;
            ScoreText.text = NewTag.ToString() + "/" + TargetNewTag.ToString();

            if (NewTag==TargetNewTag)

            {
                print("You Won");
                GameOver = true;
                WinScreen.SetActive(true);
            }
        }
    }
    public void ButtonTouch()
    {
        SceneManager.LoadScene("SampleScene");
    }
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 vel = rb.angularVelocity;
        vel.y *= 0.9f; // ?? ???????????? ? ????? ???? ????? ????????
        rb.angularVelocity = vel;
    }
}
