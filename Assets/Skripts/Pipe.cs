
using UnityEngine;
public class Pipe : MonoBehaviour {

    private Character character;
    public GameObject pipeDown;
    // Use this for initialization
    void Start () {
        character = FindObjectOfType<Character>();
    }

      
       // Update  called once per frame
       void Update () {

       if (character.transform.position.x - transform.position.x > 5)
        {
Debug.Log(character.transform.position.x - transform.position.x);
            float xRan = Random.Range(0, 6);
            float yRan = Random.Range(-6, -3);
            float gapRan = Random.Range(4, 6);

            GameObject pipeUp = Instantiate(gameObject, new Vector2(character.transform.position.x + 9 ,   yRan), transform.rotation);
            GameObject pipe_Down = Instantiate(pipeDown, new Vector2(character.transform.position.x + 9 , 10 +  yRan), transform.rotation);
            if(pipe_Down != null)
            {
                Destroy(pipe_Down);
            }
            pipe_Down.transform.SetParent(pipeUp.transform);
                     Destroy(gameObject);
            

        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            character.Death();  
        }
    }

}