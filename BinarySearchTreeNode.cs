using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BinarySearchTreeNode
{
    public int index;
    public GameObject cube;

    public BinarySearchTreeNode leftNode = null;
    public BinarySearchTreeNode rightNode = null;

    public BinarySearchTreeNode(int index, GameObject cube){
        this.index = index;
        this.cube = cube;
    }
}
