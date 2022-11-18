﻿using System;

namespace double_linked_list
{
    class Node
    {
        /* Node class represent the node of the doubly linked list
         * it consists of the information part and links to
         * its succeding and preceeding
         * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //pointto the preceeding node
        public Node prev;
    }
}
