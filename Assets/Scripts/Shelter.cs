using UnityEngine;

public class Shelter : MonoBehaviour
{
    [SerializeField]
    private Hazard enemigo;
    private Collider2D mCollider;

    [SerializeField]
    private int maxResistance = 5;
    float Tiempo = 0f;

    private void Update()
    {
        Tiempo += Time.deltaTime;
    }

    public int MaxResistance
    {
        get
        {
            return maxResistance;
        }
        protected set
        {
            maxResistance = value;
        }
    }

    public void Damage(int damage)
    {
        
    }

    public void regenTime()
    {
        if (Tiempo > 10f && maxResistance < 5f)
        {
            maxResistance++;
            Tiempo = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Hazard>() != null)
        {
            maxResistance --;
        }

        if (maxResistance <= 0)
        {
            Time.timeScale = 0F;
            Destroy(gameObject);
            print("Game Over");
        }
    }
}