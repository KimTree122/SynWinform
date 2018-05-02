using CS.Models.BaseInfo;
using DevComponents.AdvTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.UI.DataTools
{
    public class AuthNodes
    {
        public List<Node> CreatTreeNodes( List<Authority> authorities ,bool showcheck , int parentid = 0)
        {
            List<Node> treeNodes = new List<Node>();
            foreach (var au in authorities)
            {
                if (au.ParentID == parentid)
                {
                    Node node = new Node
                    {
                        Text = au.AuthName,
                        Tag = au
                    };
                    node.CheckBoxVisible = showcheck;
                    treeNodes.Add(node);
                    AddSon(node, authorities,showcheck);
                }
            }
            return treeNodes;
        }

        private void AddSon(Node node, List<Authority> aus,bool showcheck)
        {
            Authority fau = (Authority)node.Tag;
            foreach (var au in aus)
            {
                if (au.ParentID == fau.id)
                {
                    Node snode = new Node(au.AuthName)
                    {
                        Tag = au
                    };
                    snode.CheckBoxVisible = showcheck;
                    node.Nodes.Add(snode);
                    AddSon(snode, aus,showcheck);
                }
            }
        }

        public List<Authority> GetCheckNode(NodeCollection tree)
        {
            List<Authority> checkauth = new List<Authority>();
            foreach (Node node in tree)
            {
                if (node.Checked)
                {
                    List<Authority> nodeauth = new List<Authority>();
                         nodeauth = GetNodeAuth(nodeauth,node);
                    checkauth.AddRange(nodeauth);
                }
            }
            return checkauth;
        }

        private List<Authority> GetNodeAuth(List<Authority> nauths, Node node)
        {
            if (!node.Checked) return nauths;
            
            Authority auth = node.Tag as Authority;
            nauths.Add(auth);
            if (node.Nodes != null)
            {
                foreach (Node n in node.Nodes)
                {
                    GetNodeAuth(nauths, n);
                }
            }
            return nauths;
        }

        public List<Authority> GetUserNode(NodeCollection tree)
        {
            List<Authority> auths = new List<Authority>();
            foreach (Node node in tree)
            {
                List<Authority> a = new List<Authority>();
                a = GetUserNode(a, node);
                auths.AddRange(a);
            }
            return auths;
        }

        private List<Authority> GetUserNode(List<Authority> a, Node node)
        {
            if (node.Checked)
            {
                Authority au = node.Tag as Authority;
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
    }
}
