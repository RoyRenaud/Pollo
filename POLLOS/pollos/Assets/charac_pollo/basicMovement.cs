using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class basicMovement : MonoBehaviour
{
    public float jumpSpeed = 5f;
    public Rigidbody rb;
    public float jumps = 0f;
    Vector3 zero = new Vector3(0,0,0);
    public float speed = 5f;
    public float sensitivity;
    public float maxJumps = 1f;
    Animator anim;
    public GameObject audio_object;

    private bool jumping = false;

    public AudioClip jumpClip;
    public AudioClip landClip;
    public AudioClip dobleClip;
    public AudioClip tripleClip;
    public AudioClip contratulation;

    private AudioSource audio;
    public GameObject asma;

    private AudioSource giant;
    void Awake()
    {
        audio_object =  GameObject.Find("audio");
        asma = GameObject.Find("audio");

    }
    void Start()
    {
        giant = asma.GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        audio = audio_object.GetComponent<AudioSource>();
        
    }

    void Update()
    {
        Cursor.visible = false;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float mouseInput = Input.GetAxis("Mouse X") * sensitivity;
        float move = Input.GetAxis("Vertical") + Input.GetAxis("Horizontal");
        anim.SetFloat("speed", move);

        
        if (Input.GetKeyDown(KeyCode.Space) && jumps < maxJumps)
        {
            rb.velocity = zero;
            rb.AddRelativeForce(Vector3.up * jumpSpeed);
            jumps += 1f;

            anim.SetBool("jump",true);
            anim.SetBool("floor", false);
            audio.PlayOneShot(jumpClip, 1);
            jumping = true;
        } 

        if (Input.GetKeyDown(KeyCode.Backspace)) {
            maxJumps += 1;
        }

        if (maxJumps == 4)
        {
            giant.Stop();
            audio.PlayOneShot(contratulation, 1);
            
            StartCoroutine(EndTheLevel());
            maxJumps += 1;
        }

        transform.Rotate(0, mouseInput, 0);
        transform.Translate(x, 0, z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (jumping == true)
        {
            audio.PlayOneShot(landClip, 1);
        }

        jumps = 0f;
        anim.SetBool("jump", false);
        anim.SetBool("floor", true);
        jumping = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (maxJumps == 1)
        {
            audio.PlayOneShot(dobleClip, 1);
        } else if (maxJumps == 2)
        {
            audio.PlayOneShot(tripleClip, 1);
        }
        maxJumps += 1f;
        other.gameObject.SetActive(false);
        
    }

    IEnumerator EndTheLevel ()
    {
        yield return new WaitForSecondsRealtime(25f);
        SceneManager.LoadScene("victoria", LoadSceneMode.Single);
    }

  

    public float GetMaxJumps()
    {
        return maxJumps;
    }
}