using UnityEngine;

public class CollectableRotation : MonoBehaviour
{
    // Update is called once per frame
    private void Start()
    {
        transform.Rotate(new Vector3(Random.Range(-180f, 180f), 
                                    0f, 
                                    0f
                                    )
                        );
        transform.position = transform.position + new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f));
    }
    void Update() 
    {
        transform.Rotate(new Vector3(1f,1f,1f));
        //Debug.Log(Random.Range(0f,10f));
    }
}
