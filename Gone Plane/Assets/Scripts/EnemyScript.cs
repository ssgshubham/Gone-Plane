
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] float movespeed;
    [SerializeField] float rotatespeed;

    


    [SerializeField] Transform player;
    public AudioClip audClip;
    public AudioSource Auds;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion r = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, r, rotatespeed*Time.deltaTime);
    }


    void FixedUpdate()
    {
       
            rb.AddRelativeForce(new Vector3(movespeed * Time.fixedDeltaTime, 0f, 0f));
          
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bullet")
        {
            Auds.PlayOneShot(audClip);

            Debug.Log("working");
            GameDataManager.AddCoins(1);

            // Cheating (while moving hold key "C" to get extra coins) 
			#if UNITY_EDITOR
			if (Input.GetKey (KeyCode.C))
				GameDataManager.AddCoins (179);
			#endif

            GameSharedUI.Instance.UpdateCoinsUIText ();
            Destroy(gameObject);

        }

        

        if (col.tag == "bullet1")
        {
            Debug.Log("dd");
            Auds.PlayOneShot(audClip);
            Destroy(gameObject);
            GameDataMF.AddCoins(32);
            // Cheating (while moving hold key "C" to get extra coins) 
            #if UNITY_EDITOR
			if (Input.GetKey (KeyCode.C))
				GameDataMF.AddCoins (179);
            #endif
            GameSUIF.Instance.UpdateCoinsUIText();
        }


        if (col.tag == "bullet2")
        {
            Debug.Log("dd");
            Auds.PlayOneShot(audClip);
            Destroy(gameObject);
            GameDataMH.AddCoins(32);
            // Cheating (while moving hold key "C" to get extra coins) 
            #if UNITY_EDITOR
			if (Input.GetKey (KeyCode.C))
				GameDataMH.AddCoins (179);
            #endif
            GameSUIH.Instance.UpdateCoinsUIText();
        }

        if (col.tag == "bullet3")
        {
            Debug.Log("dd");
            Auds.PlayOneShot(audClip);
            Destroy(gameObject);           
        }
    }

   

}
