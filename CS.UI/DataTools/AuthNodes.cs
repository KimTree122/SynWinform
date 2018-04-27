using CS.Models.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS.UI.DataTools
{
    public class AuthNodes
    {
        public List<TreeNode> CreatTreeNodes( List<Authority> authorities, int parentid = 0)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();
            foreach (var auth in authorities)
            {
                if (auth.ParentID == parentid )
                {
                    TreeNode ftn = new TreeNode(auth.AuthName);
                    ftn.Tag = auth;
                    ftn.Name = auth.AuthName;
                    TreeNode stn = GetSonTreeNode(authorities, auth);
                    if ( !string.IsNullOrWhiteSpace( stn.Text))
                    {
                        ftn.Nodes.Add(stn);
                    }
                    treeNodes.Add(ftn);
                }
            }
            return treeNodes;
        }

        private TreeNode GetSonTreeNode(List<Authority> authorities, Authority auth)
        {
            TreeNode stn = new TreeNode();
            foreach (Authority au in authorities)
            {
                if (au.ParentID == auth.id)
                {
                    stn.Text = au.AuthName;
                    stn.Name = au.AuthName;
                    stn.Tag = au;
                    TreeNode t = GetSonTreeNode(authorities, au);
                    stn.Nodes.Add(t);
                }
            }
            return stn;
        }
    }
}
