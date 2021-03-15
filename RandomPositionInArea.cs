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

        void Initialize() 
        {
            xRange = transform.localScale.x / 2f;
            yRange = transform.localScale.y / 2f;
            zRange = transform.localScale.z / 2f;
        }

        float Range(float x, float range)
        {
            return x + Random.Range(-range, range);
        }
		
		public Vector3 SpawnPositionNoHeight()
		{
			Vector3 posi;

            posi = new Vector3(Range(transform.position.x, xRange), transform.position.y, Range(transform.position.z, zRange));

            return posi;	
		}
		
        public Vector3 SpawnPosition()
        {
            Vector3 posi;

            posi = new Vector3(Range(transform.position.x, xRange), Range(transform.position.y, yRange), Range(transform.position.z, zRange));

            return posi;
        }
    }
}
