
using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;
    
    private void Start()
    {
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bound = this.gridArea.bounds;

        float x = Random.Range(bound.min.x, bound.max.x);
        float y = Random.Range(bound.min.y, bound.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        RandomizePosition();
        
    }
}
