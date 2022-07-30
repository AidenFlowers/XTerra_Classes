using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CollectableManager : MonoBehaviour
    {
        public static CollectableManager Instance;
        public int totalCubesToCollect;
        public int collectedCount;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }
        
        public void addOneToCount()
        {
            collectedCount++;
            Debug.Log("Adding one to count.  You are now at: " + collectedCount);
            if(collectedCount == totalCubesToCollect)
            {
                Debug.Log("You collected all the cubes! You win!");
            }

        }

    // Start is called before the first frame update
        void Start()
        {
            collectedCount = 0;
        }



    }
