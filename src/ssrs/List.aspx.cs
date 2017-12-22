using ssrs.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ssrs
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                RefreshItems();
        }

        private void RefreshItems()
        {
            Wrapper wrapper = new Wrapper();
            CatalogItem[] items = wrapper.GetItems("/");
            this.TreeViewItems.Nodes.Clear();
            RefreshItems(wrapper, this.TreeViewItems.Nodes, items);
        }

        private void RefreshItems(Wrapper wrapper, TreeNodeCollection nodes, CatalogItem[] items)
        {
            foreach (CatalogItem item in items)
            {
                bool isFolder = item.TypeName == "Folder";
                bool isReport = item.TypeName == "Report";
                if ((!isFolder) && (!isReport))
                    continue;
                TreeNode node = new TreeNode(item.Name, isReport ? item.Path : string.Empty);
                nodes.Add(node);
                if (isFolder)
                    this.RefreshItems(wrapper, node.ChildNodes, wrapper.GetItems(item.Path));
            }
        }

        protected void TreeViewItems_SelectedNodeChanged(object sender, EventArgs e)
        {
            string value = this.TreeViewItems.SelectedNode.Value;
            if (string.IsNullOrEmpty(value))
                return;
            this.Response.Redirect(string.Format("~/View.aspx?Url={0}", value));
        }
    }
}