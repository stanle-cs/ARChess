using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class SnapGrid : MonoBehaviour
{
    GameManager gameManager;

    public GameObject[,] snapArray;
    GameObject snapMesh;

    const float GRID_OFFSET = 0.06f;
    const float SNAP_DISTANCE = 0.02f;
    const float Y_DISTANCE = 0.01f;
    const float MIN_SNAP_DISTANCE = 0.00005f;
    private void Awake()
    {
        gameManager= GetComponent<GameManager>();
        snapArray = new GameObject[10,10];

        snapMesh = GameObject.Find("a1");
        
        // Create snap array
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0;j< 10; j++)
            {
                snapArray[i,j] =  Instantiate(snapMesh, parent: snapMesh.transform.parent);
                snapArray[i,j].transform.localPosition = new Vector3(snapMesh.transform.localPosition.x + GRID_OFFSET* (j-1),
                                                                     snapMesh.transform.localPosition.y,
                                                                     snapMesh.transform.localPosition.z - GRID_OFFSET*(i-1));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject piece;
        // check for snap
        foreach (var chessPiece in gameManager.chessPieces.Values.ToListPooled())
        {
            piece = chessPiece.gameObject;
            // If dropped, move back to the table
            if (piece.transform.position.y < 0)
            {
                piece.GetComponent<Rigidbody>().velocity = Vector3.zero;
                piece.transform.localRotation = new Quaternion(0f,
                                                              0f,
                                                              piece.transform.localRotation.z,
                                                              piece.transform.localRotation.w);
                gameManager.MovePiece(piece.name,
                                      gameManager.chessPieces[piece.name].square.rank,
                                      gameManager.chessPieces[piece.name].square.file);
            }

            // Snap to grid
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (Vector3.Distance(piece.transform.position, snapArray[i, j].transform.position) < SNAP_DISTANCE
                            && Mathf.Abs(piece.transform.position.y - snapArray[i, j].transform.position.y) < Y_DISTANCE
                            && Vector3.Distance(piece.transform.position, snapArray[i,j].transform.position) > MIN_SNAP_DISTANCE)
                    {
                        gameManager.MovePiece(piece.name, i, j);
                        piece.transform.localRotation = new Quaternion(0f,
                                                                       0f,
                                                                       piece.transform.localRotation.z,
                                                                       piece.transform.localRotation.w);
                    }
                }
            } 
        }
    }
}
