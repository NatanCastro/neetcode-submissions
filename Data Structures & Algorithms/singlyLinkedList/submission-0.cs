public class LinkedList
{
    private class Node(int val, Node? next = null)
    {
        public int val = val;
        public Node? next = next;
    }

    private Node? head = null;
    private Node? tail = null;
    private int size = 0;

    public LinkedList()
    {

    }

    public int Get(int index)
    {
        if (index >= size)
            return -1;

        Node? currNode = head;
        while (index != 0 && currNode != null)
        {
            currNode = currNode.next;
            index--;
        }

        return currNode?.val ?? 0;
    }

    public void InsertHead(int val)
    {
        if (head == null)
        {
            head = new Node(val);
            if (tail == null)
                tail = head;
        }
        else
        {
            head = new Node(val, head);
        }

        size++;
    }

    public void InsertTail(int val)
    {
        Node newTail = new Node(val);
        if (tail == null)
        {
            tail = newTail;

            if (head == null)
                head = tail;
        }
        else
        {

            tail.next = newTail;
            tail = newTail;
        }

        size++;
    }

    public bool Remove(int index)
    {
        if (index < 0 || index >= size)
            return false;

        if (index == 0)
        {
            head = head?.next;
            if (head == null)
                tail = null;
        }
        else
        {
            Node? currNode = head;
            while (index != 1 && currNode != null)
            {
                currNode = currNode.next;
                index--;
            }

            if (currNode == null || currNode.next == null)
                return false;

            currNode.next = currNode.next.next;

            if (currNode.next == null)
                tail = currNode;
        }

        size--;

        return true;
    }

    public List<int> GetValues()
    {
        List<int> list = new List<int>();

        Node? currNode = head;

        while (currNode != null)
        {
			list.Add(currNode.val);
            currNode = currNode.next;
        }

        return list;
    }
}
