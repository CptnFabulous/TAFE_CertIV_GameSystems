using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minesweeper // allows custom scripts with the same name as pre-existing scripts
{
    public class Tile : MonoBehaviour
    {
        public int x, y;
        public bool isMine = false;
        public bool isRevealed = false;
        [Header("References")]
        public Sprite[] emptySprites;
        public Sprite[] mineSprites;
        private SpriteRenderer sr;

        private void Awake()
        {
            sr = GetComponent<SpriteRenderer>();
        }

        // Use this for initialization
        void Start()
        {
            isMine = Random.value < 0.5f;
        }

        
        /*
        // Update is called once per frame
        void Update()
        {

        }
        */

        public void Reveal(int adjacentMines, int mineState = 0)
        {
            isRevealed = true;

            if (isMine)
            {
                sr.sprite = mineSprites[mineState];
            }
            else
            {
                sr.sprite = emptySprites[adjacentMines];
            }
        }
    }
}


