﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Node { public int data; public Node next; };
    class LinkedList
    {
        public Node head;
        //constructor to create an empty LinkedList
        public LinkedList() { head = null; }
    };    // test the code 
    class Implementation
    {
        static void main(string[] args)
        {
            //create an empty LinkedList
            LinkedList MyList = new LinkedList();
            //Add first node.
            Node first = new Node();
            first.data = 10; first.next = null;
            //linking with head node
            MyList.head = first;
            //Add second node.
            Node second = new Node(); second.data = 20; second.next = null;
            //linking with first node
            first.next = second;
            //Add third node.
            Node third = new Node(); third.data = 30; third.next = null;
            //linking with second node
            second.next = third;
        }
    }
}