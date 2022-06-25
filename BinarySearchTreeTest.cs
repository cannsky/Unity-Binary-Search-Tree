using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchTreeTest : MonoBehaviour
{
    public int[] indexes;
    public GameObject[] cubes;

    public static BinarySearchTree binarySearchTree;

    void Start()
    {
        binarySearchTree = new BinarySearchTree(indexes, cubes);
    }
}
