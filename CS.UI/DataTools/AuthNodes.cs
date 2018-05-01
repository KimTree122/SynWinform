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
    }
}
