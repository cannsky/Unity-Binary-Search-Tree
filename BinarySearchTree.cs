using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BinarySearchTree
{
    public BinarySearchTreeNode rootNode;

    public BinarySearchTree(int[] indexes, GameObject[] cubes){
        for(int i = 0; i < indexes.Length; i++){
            if(i == 0) rootNode = new BinarySearchTreeNode(indexes[i], cubes[i]);
            else InsertToBinarySearchTree(rootNode, indexes[i], cubes[i]);
        }
    }

    public void InsertToBinarySearchTree(BinarySearchTreeNode currentNode, int index, GameObject cube){
        if(currentNode.index < index){
            if(currentNode.leftNode == null) currentNode.leftNode = new BinarySearchTreeNode(index, cube);
            else InsertToBinarySearchTree(currentNode.leftNode, index, cube);
        }
        else {
            if(currentNode.rightNode == null) currentNode.rightNode = new BinarySearchTreeNode(index, cube);
            else InsertToBinarySearchTree(currentNode.rightNode, index, cube);
        }
    }

    public void FindBinarySearchTreeNode(BinarySearchTreeNode currentNode, int index){
        if(currentNode == null) return;
        if(currentNode.index == index) currentNode.cube.gameObject.SetActive(false);
        if(currentNode.index < index) FindBinarySearchTreeNode(currentNode.leftNode, index);
        else FindBinarySearchTreeNode(currentNode.rightNode, index);
    }
}
