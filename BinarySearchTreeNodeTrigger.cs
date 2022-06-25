using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearchTreeNodeTrigger : MonoBehaviour
{
    public int index;

    public void Start() => index = gameObject.GetComponent<TestNode>().index;

    public void OnTriggerEnter(Collider other){
        if(other.tag != "Player") return;
        Debug.Log("Triggered!");
        BinarySearchTreeTest.binarySearchTree.FindBinarySearchTreeNode(BinarySearchTreeTest.binarySearchTree.rootNode, index);
    }
}
