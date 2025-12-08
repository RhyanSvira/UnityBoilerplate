using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D _enemyRigidBody2D;
    [FormerlySerializedAs("UnitsToMove")] public int unitsToMove = 8;
    [FormerlySerializedAs("EnemySpeed")] public float enemySpeed = 500;
    [FormerlySerializedAs("_isFacingRight")] public bool isFacingRight;
    private float _startPos;
    private float _endPos;

    [FormerlySerializedAs("_moveRight")] public bool moveRight = true;


    // Use this for initialization
    public void Awake()
    {
        _enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + unitsToMove;
        isFacingRight = transform.localScale.x > 0;
    }


// Update is called once per frame
    public void Update()
    {

        if (moveRight)
        {
            _enemyRigidBody2D.AddForce(Vector2.right * (enemySpeed * Time.deltaTime));
            if (!isFacingRight)
                Flip();
        }

        if (_enemyRigidBody2D.position.x >= _endPos)
            moveRight = false;

        if (!moveRight)
        {
            _enemyRigidBody2D.AddForce(-Vector2.right * (enemySpeed * Time.deltaTime));
            if (isFacingRight)
                Flip();
        }
        if (_enemyRigidBody2D.position.x <= _startPos)
            moveRight = true;


    }

    private void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        isFacingRight = transform.localScale.x > 0;
    }

}