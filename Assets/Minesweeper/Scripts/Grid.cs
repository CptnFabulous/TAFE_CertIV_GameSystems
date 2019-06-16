using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper // allows custom scripts with the same name as pre-existing scripts
{
    public class Grid : MonoBehaviour
    {

        public GameObject tilePrefab;
        public int width = 10, height = 10;
        public float spacing = .155f;

        private Tile[,] tiles;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        Tile SpawnTile (Vector3 pos)
        {
            GameObject clone = Instantiate(tilePrefab);
            clone.transform.position = pos;
            Tile currentTile = clone.GetComponent<Tile>();
            return currentTile;
        }
    }
}

