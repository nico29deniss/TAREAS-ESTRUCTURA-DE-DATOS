using System;

class Node
{
    public string Value;
    public Node Left, Right;
    public Node(string item)
    {
        Value = item;
        Left = Right = null;
    }
}

class BinaryTree
{
    public Node Root;

    public void Insert(string value)
    {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, string value)
    {
        if (root == null)
            return new Node(value);

        if (string.Compare(value, root.Value) < 0)
            root.Left = InsertRec(root.Left, value);
        else
            root.Right = InsertRec(root.Right, value);

        return root;
    }

    public void Delete(string value)
    {
        Root = DeleteRec(Root, value);
    }

    private Node DeleteRec(Node root, string value)
    {
        if (root == null) return root;

        if (string.Compare(value, root.Value) < 0)
            root.Left = DeleteRec(root.Left, value);
        else if (string.Compare(value, root.Value) > 0)
            root.Right = DeleteRec(root.Right, value);
        else
        {
            if (root.Left == null) return root.Right;
            if (root.Right == null) return root.Left;
            
            root.Value = MinValue(root.Right);
            root.Right = DeleteRec(root.Right, root.Value);
        }
        return root;
    }

    private string MinValue(Node root)
    {
        string minv = root.Value;
        while (root.Left != null)
        {
            minv = root.Left.Value;
            root = root.Left;
        }
        return minv;
    }

    public void PreOrder(Node node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public void InOrder(Node node)
    {
        if (node != null)
        {
            InOrder(node.Left);
            Console.Write(node.Value + " ");
            InOrder(node.Right);
        }
    }

    public void PostOrder(Node node)
    {
        if (node != null)
        {
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Value + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Insertar nodo");
            Console.WriteLine("2. Eliminar nodo");
            Console.WriteLine("3. Recorrido PreOrden");
            Console.WriteLine("4. Recorrido InOrden");
            Console.WriteLine("5. Recorrido PostOrden");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese valor a insertar: ");
                    string val = Console.ReadLine();
                    tree.Insert(val);
                    break;
                case "2":
                    Console.Write("Ingrese valor a eliminar: ");
                    string delVal = Console.ReadLine();
                    tree.Delete(delVal);
                    break;
                case "3":
                    Console.Write("PreOrden: ");
                    tree.PreOrder(tree.Root);
                    Console.WriteLine();
                    break;
                case "4":
                    Console.Write("InOrden: ");
                    tree.InOrder(tree.Root);
                    Console.WriteLine();
                    break;
                case "5":
                    Console.Write("PostOrden: ");
                    tree.PostOrder(tree.Root);
                    Console.WriteLine();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}
