using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d; //Får fram spelarens Rigidbody. -Christian
    public Animator animator; //Får fram animatorn. -Christian
    [Header("Movement")]
    [SerializeField, Range(1, 25)]
    public float speed = 10f; //Rörelse hastighet. -Christian
    bool interacting; //Kollar om spelaren interagerar. -Christian
    public BoxCollider2D interactingCollider; //Hitboxen av när man interagerar. -Christian
    Collider2D interactable; //Kollar om spelaren interagerar. -Christian
    public float selectionRadius = 1;
    public LayerMask ItemMask;
    public float offset = 1;
    Vector3 interactingGizmos;

    Vector2 movementVector;
    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal"); //Kollar knapptryck i horizontal axel. Höger eller vänster. -Christian
        movementVector.y = Input.GetAxisRaw("Vertical"); //Kollar knapptryck i vertikal axel. Upp eller ner. -Christian
        animator.SetFloat("Horizontal Movement", movementVector.x); //Ger knapptrycket till animatorn. -Christian
        animator.SetFloat("Vertical Movement", movementVector.y);
        animator.SetFloat("Speed", movementVector.sqrMagnitude); //Get hastigheten til animatorn. -Christian

        interactingGizmos = transform.position + new Vector3(movementVector.x * offset, movementVector.y * offset, 0);
        interactable = Physics2D.OverlapCircle(interactingGizmos, selectionRadius, ItemMask);
        if (interactable != null)
        {
            if (interactable.gameObject.GetComponent<Item>() != null && Input.GetKey(KeyCode.E))
            {
                interactable.gameObject.GetComponent<Item>().Interact();
            }
        }

    }
    // UpdateFixed is a physics based Update
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movementVector * speed * Time.fixedDeltaTime); //Rör på spelaren baserat på knapptryck. -Christian
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(interactingGizmos, selectionRadius);
    }
}
