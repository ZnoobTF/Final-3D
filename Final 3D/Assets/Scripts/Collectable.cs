using System.Runtime.CompilerServices;
using UnityEngine;
public enum Rarity {
    Common,Uncommon,Rare
}
// Add an enum to represent an item's rarity.

public class Collectable : MonoBehaviour
{
    // Add a member varible to represent each collectable's rarity. Make sure
    //      it can be tuned from the Inspector
    [SerializeField] private Rarity rarity;
    private Collider[] _colliders;
    private Rigidbody _rigidbody;
    private GameController _gameController;

    // ------------------------------------------------------------------------
    private void Start ()
    {
        _gameController = FindFirstObjectByType<GameController>();
        _colliders = GetComponents<Collider>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // ------------------------------------------------------------------------
    // You might want to add parameters to this method.
    public void Collect (Transform collectable)
    {
        // Set the new parent and position of the Collectable.
        // Disable all of this object's colliders.
        transform.SetParent(collectable);
        transform.localPosition = Vector3.zero;
        foreach (Collider c in _colliders)
        {
            c.enabled = false;
        }
       

        // This line sets the rigidbody to kinematic so it'll stop using physics.
        // (You don't need to change this.)
        _rigidbody.isKinematic = true;

        // Tell the GameController that we collected this item.
        _gameController.CollectItem(rarity);

    }

    // ------------------------------------------------------------------------
    // You might want to add parameters to this method.
    public void Drop (Vector3 droppos)
    {
        // Reset this object's parent so it's no longer attached to the Katamari,
        //  and give it a new position ABOVE the Katamari sphere.
        transform.SetParent(null);
        transform.position = droppos;

        // Enable all of this object's colliders.
        foreach(Collider c in _colliders) {
            c.enabled = true;
        }
        

        // This line sets the rigidbody to kinematic so it'll start using physics again.
        // (You don't need to change this.)
        _rigidbody.isKinematic = false;

        // Add a force to the rigidbody to make it fly upwards.
        _rigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        // Tell the UI that we removed this item.
        _gameController.RemoveItem(rarity);

    }
}