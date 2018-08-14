using CS.Models.BaseInfo;
using DevComponents.AdvTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.UI.DataTools
{
    //public class AuthNodes
    //{
    //    public List<Node> CreatTreeNodes( List<Authority> authorities ,bool showcheck , int parentid = 0)
    //    {
    //        List<Node> treeNodes = new List<Node>();
    //        foreach (var au in authorities)
    //        {
    //            if (au.ParentID == parentid)
    //            {
    //                Node node = new Node
    //                {
    //                    Text = au.TreeName,
    //                    Tag = au
    //                };
    //                node.CheckBoxVisible = showcheck;
    //                treeNodes.Add(node);
    //                AddSon(node, authorities,showcheck);
    //            }
    //        }
    //        return treeNodes;
    //    }

    //    private void AddSon(Node node, List<Authority> aus,bool showcheck)
    //    {
    //        Authority fau = (Authority)node.Tag;
    //        foreach (var au in aus)
    //        {
    //            if (au.ParentID == fau.id)
    //            {
    //                Node snode = new Node(au.TreeName)
    //                {
    //                    Tag = au
    //                };
    //                snode.CheckBoxVisible = showcheck;
    //                node.Nodes.Add(snode);
    //                AddSon(snode, aus,showcheck);
    //            }
    //        }
    //    }

    //    public List<Authority> GetUserNode(NodeCollection tree)
    //    {
    //        List<Authority> auths = new List<Authority>();
    //        foreach (Node node in tree)
    //        {
    //            List<Authority> a = new List<Authority>();
    //            a = GetUserNode(a, node);
    //            auths.AddRange(a);
    //        }
    //        return auths;
    //    }

    //    private List<Authority> GetUserNode(List<Authority> a, Node node)
    //    {
    //        if (node.Checked)
    //        {
    //            Authority au = node.Tag as Authority;
    //            a.Add(au);
    //        }
    //        if (node.Nodes != null)
    //        {
    //            foreach (Node n in node.Nodes)
    //            {
    //                GetUserNode(a, n);
    //            }
    //        }
    //        return a;
    //    }

    //    public void ShowTreeView(AdvTree adv, List<Authority> auths,bool showcheck)
    //    {
    //        adv.Nodes.Clear();
    //        List<Node> nodes = CreatTreeNodes(auths, showcheck);
    //        foreach (Node tn in nodes)
    //        {
    //            adv.Nodes.Add(tn);
    //        }
    //        adv.ExpandAll();
    //    }

    //    public List<Authority> GetAuthByNodesCheck(NodeCollection tree)
    //    {
    //        List<Node> nodelist = new List<Node>();
    //        foreach (Node node in tree)
    //        {
    //            List<Node> nodes = new List<Node>();
    //            nodes = GetSonNode(nodes, node);
    //            nodelist.AddRange(nodes);
    //        }

    //        List<Node> checknode = new List<Node>();
    //        foreach (Node node in nodelist)
    //        {
    //            if (node.Checked)
    //            {
    //                checknode.Add(node);
    //                List<Node> nodes = new List<Node>();
    //                if (node.Parent != null)
    //                {
    //                    nodes = GetParentNode(nodes, node.Parent);
    //                    checknode.AddRange(nodes);
    //                }
    //            }
    //        }

    //        checknode = checknode.Distinct().ToList();
    //        List<Authority> authorities = new List<Authority>();
    //        foreach (Node node in checknode)
    //        {
    //            authorities.Add(node.Tag as Authority);
    //        }

    //        return authorities;
    //    }

    //    private List<Node> GetParentNode(List<Node> nodes, Node parent)
    //    {
    //        nodes.Add(parent);
    //        if (parent.Parent != null)
    //        {
    //            GetParentNode(nodes, parent.Parent);
    //        }
    //        return nodes;
    //    }

    //    private List<Node> GetSonNode(List<Node> nodes, Node node)
    //    {
    //        nodes.Add(node);
    //        if (node.Nodes != null)
    //        {
    //            foreach (Node snode in node.Nodes)
    //            {
    //                GetSonNode(nodes, snode);
    //            }
    //        }
    //        return nodes;
    //    }
    //}

    public class NodesTools
    {
        private List<Node> GetNodes<T>(List<T> treelist, bool checkbox, int parentid = 0)
        {
            List<Node> treeNodes = new List<Node>();
            foreach (var au in treelist)
            {
                BaseTree baseTree = (BaseTree)(object) au ;
                T t = (T)(object)au;

                if (baseTree.ParentID == parentid)
                {
                    Node node = new Node
                    {
                        Text = baseTree.TreeName,
                        Tag = t
                    };
                    node.CheckBoxVisible = checkbox;
                    treeNodes.Add(node);
                    AddSon(node, treelist, checkbox);
                }
            }
            return treeNodes;
        }

        private void AddSon<T>(Node node, List<T> treelist, bool checkbox)
        {
            BaseTree fau = (BaseTree)node.Tag;
            foreach (var au in treelist)
            {
                BaseTree baseTree = (BaseTree)(object)au;
                T t = (T)(object)au;
                if (baseTree.ParentID == fau.id)
                {
                    Node snode = new Node(baseTree.TreeName)
                    {
                        Tag = t
                    };
                    snode.CheckBoxVisible = checkbox;
                    node.Nodes.Add(snode);
                    AddSon(snode, treelist, checkbox);
                }
            }
        }

        public void ShowTreeView<T>(AdvTree adv, List<T> auths, bool showcheck)
        {
            adv.Nodes.Clear();
            List<Node> nodes = GetNodes(auths, showcheck);
            foreach (Node tn in nodes)
            {
                adv.Nodes.Add(tn);
            }
            adv.ExpandAll();
        }

        public List<T> GetUserNode<T>(NodeCollection tree)
        {
            List<T> auths = new List<T>();
            foreach (Node node in tree)
            {
                List<T> a = new List<T>();
                a = GetUserNode(a, node);
                auths.AddRange(a);
            }
            return auths;
        }

        private List<T> GetUserNode<T>(List<T> a, Node node)
        {
            if (node.Checked)
            {
                T au = (T) node.Tag;
                a.Add(au);
            }
            if (node.Nodes != null)
            {
                foreach (Node n in node.Nodes)
                {
                    GetUserNode(a, n);
                }
            }
            return a;
        }

        public List<T> GetAuthByNodesCheck<T>(NodeCollection tree)
        {
            List<Node> nodelist = new List<Node>();
            foreach (Node node in tree)
            {
                List<Node> nodes = new List<Node>();
                nodes = GetSonNode(nodes, node);
                nodelist.AddRange(nodes);
            }

            List<Node> checknode = new List<Node>();
            foreach (Node node in nodelist)
            {
                if (node.Checked)
                {
                    checknode.Add(node);
                    List<Node> nodes = new List<Node>();
                    if (node.Parent != null)
                    {
                        nodes = GetParentNode(nodes, node.Parent);
                        checknode.AddRange(nodes);
                    }
                }
            }

            checknode = checknode.Distinct().ToList();
            List<T> authorities = new List<T>();
            foreach (Node node in checknode)
            {
                authorities.Add((T) node.Tag);
            }

            return authorities;
        }

        private List<Node> GetParentNode(List<Node> nodes, Node parent)
        {
            nodes.Add(parent);
            if (parent.Parent != null)
            {
                GetParentNode(nodes, parent.Parent);
            }
            return nodes;
        }

        private List<Node> GetSonNode(List<Node> nodes, Node node)
        {
            nodes.Add(node);
            if (node.Nodes != null)
            {
                foreach (Node snode in node.Nodes)
                {
                    GetSonNode(nodes, snode);
                }
            }
            return nodes;
        }

    }
}
