using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JoaoMilone
{
    public class RandomPositionInArea : MonoBehaviour
    {
        private float xRange = 10f, yRange = 10f ,zRange = 10f;

        [SerializeField]
        private Color GizmosColor = new Color(0.5f, 0.5f, 0.5f, 0.2f);

        void OnDrawGizmos()
        {
            Gizmos.color = GizmosColor;
            Gizmos.DrawCube(transform.position, transform.localScale);
        }

        private void Start()
        {
            Initialize();
        }

        //Gets stats from localscale of your spawn area
        void Initialize() 
        {
            xRange = transform.localScale.x / 2f;
            yRange = transform.localScale.y / 2f;
            zRange = transform.localScale.z / 2f;
        }

        //Random position in a range
        float Range(float x, float range)
        {
            return x + Random.Range(-range, range);
        }
		

        ///<summary>
        ///Will choose a random position inside area choosing a random X, Z and with fixed Y value.
        ///</summary>
		public Vector3 SpawnPositionNoHeight()
		{
			Vector3 posi;

            posi = new Vector3(Range(transform.position.x, xRange), transform.position.y, Range(transform.position.z, zRange));

            return posi;	
		}

		///<summary>
        ///Will choose a random position in X, Y Z.
        ///</summary>
        public Vector3 SpawnPosition()
        {
            Vector3 posi;

            posi = new Vector3(Range(transform.position.x, xRange), Range(transform.position.y, yRange), Range(transform.position.z, zRange));

            return posi;
        }
    }
}
