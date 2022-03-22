using UnityEngine;

public class MoveCar : MonoBehaviour
{

    public float moveSpeed = 30f;
    public float turnSpeed = 120f;

    //Awake is called after the script will load
    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //FixedUpdate is called once in physics iteration
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}