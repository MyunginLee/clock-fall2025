using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using TMPro;
public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    Vector2 movementVector;
    private float movementX, movementY;
    public float scale;
    public GameObject mother;
    private GameObject[] clones;
    public TextMeshProUGUI countText;
    private int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scale = 13f;
        rb = GetComponent<Rigidbody>();
        clones = new GameObject[1000];

        for (int i = 0; i < 1000; i++)
        {
            clones[i] = Instantiate(mother);
            clones[i].transform.position = new Vector3(0f, 0f, i);
        }
    }

    void OnMove(InputValue movementValue)
    {
        movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log(Time.deltaTime);
    //}
    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0f, movementY);
        rb.AddForce(movement * scale);
        //Debug.Log("!!Fixed update");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable")) {
            score++;
            countText.text = score.ToString();
            //Debug.Log(score);
            // write the score into a text
            other.gameObject.SetActive(false);
        };
    }

}
