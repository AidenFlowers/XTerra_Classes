using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CollectableCube : MonoBehaviour
    {
        MeshRenderer rend;
        BoxCollider collider;

        // Start is called before the first frame update
        void Start()
        {
            rend = GetComponent<MeshRenderer>();
            collider = GetComponent<BoxCollider>();
        }

        private void OnTriggerEnter(Collider other)
        {  //Blue means Unity will call it for us
            if(other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Collided with the Player!");
                rend.enabled = false;
                collider.enabled = false;
                CollectableManager.Instance.addOneToCount();

            }
        }


    }

