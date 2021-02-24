namespace Helpers
{
    public class DoublyListNode<T>
    {
        public T val;
        public DoublyListNode<T> next;
        public DoublyListNode<T> prev;
        public DoublyListNode(T val = default, DoublyListNode<T> next = null, DoublyListNode<T> prev = null)
        {
            this.val = val;
            this.next = next;
            this.prev = prev;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class DoublyLinkedList<T>
    {
        public DoublyListNode<T> head;
        public DoublyListNode<T> tail;

        public DoublyLinkedList<T> InsertAtHead(DoublyListNode<T> node)
        {
            if(node.prev != null) node.prev.next = node.next;
            if (node.next != null) node.next.prev = node.prev;

            node.next = this.head;
            node.prev = null;
            this.head = node;
            this.tail ??= this.head;
            return this;
        }

        public DoublyLinkedList<T> InsertAtTail(DoublyListNode<T> node)
        {
            if (node.prev != null) node.prev.next = node.next;
            if (node.next != null) node.next.prev = node.prev;

            node.prev = this.tail;
            if(this.tail != null) this.tail.next = node;
            node.next = null;
            this.tail = node;
            this.head ??= this.tail;
            return this;
        }

        public DoublyLinkedList<T> InsertAfter(DoublyListNode<T> node1, DoublyListNode<T> node2)
        {
            if (node1.prev != null) node1.prev.next = node1.next;
            if (node1.next != null) node1.next.prev = node1.prev;

            node1.prev = node2;
            node1.next = node2.next;
            node2.next = node1;
            return this;
        }

        public DoublyLinkedList<T> InsertBefore(DoublyListNode<T> node1, DoublyListNode<T> node2)
        {
            if (node1.prev != null) node1.prev.next = node1.next;
            if (node1.next != null) node1.next.prev = node1.prev;

            node1.next = node2;
            node1.prev = node2.prev;
            node2.prev = node1;
            return this;
        }

        public DoublyLinkedList<T> RemoveHead()
        {
            if (this.head != null)
            {
                this.head = this.head.next;
                if (this.head == null) this.tail = null;
            }
            return this;
        }

        public DoublyLinkedList<T> Remove(DoublyListNode<T> node)
        {
            if (node != null)
            {
                if (node.prev != null) node.prev.next = node.next;
                if (node.next != null) node.next.prev = node.prev;

                if (node == head)
                {
                    head = head.next;
                }

                if (node == tail)
                {
                    tail = tail.prev;
                }
            }

            return this;
        }
    }
}