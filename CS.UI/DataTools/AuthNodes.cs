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
        public List<Node> CreatTreeNodes( List<Authority> authorities, int parentid = 0)
        {
            List<Node> treeNodes = new List<Node>();
            foreach (var au in authorities)
            {
                if (au.ParentID == parentid)
                {
                    Node node = new Node();
                    node.Text = au.AuthName;
                    node.Tag = au;
                    treeNodes.Add(node);
                    AddSon(node, authorities);
                }
            }
            return treeNodes;
        }

        private void AddSon(Node node, List<Authority> aus)
        {
            Authority fau = (Authority)node.Tag;
            foreach (var au in aus)
            {
                if (au.ParentID == fau.id)
                {
                    Node snode = new Node(au.AuthName);
                    snode.Tag = au;
                    node.Nodes.Add(snode);
                    AddSon(snode, aus);
                }
            }
        }
    }
}
