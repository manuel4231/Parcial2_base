using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class Bullet2 : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;

    private Collider2D mCollider;
    private Rigidbody2D mRigidbody;

    [SerializeField]
    private float mforce = 10F;

    [SerializeField]
    private float mautoDestroyTime = 5F;

    // Use this for initialization
    private void Start()
    {
        mCollider = GetComponent<Collider2D>();
        mRigidbody = GetComponent<Rigidbody2D>();

        mRigidbody.AddForce(transform.up * mforce, ForceMode2D.Impulse);

        Invoke("AutoDestroy", mautoDestroyTime);
    }

    private void AutoDestroy()
    {
        Destroy(gameObject);
        Destroy(gameObject);
    }
}
