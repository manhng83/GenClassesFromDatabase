using System.Windows.Forms;

namespace GenClassesFromDatabase.Controls.Nodes
{
    public class SchemaNode : TreeNode
    {
        public SchemaNode(string name, int count) : base($"{name} ({count})")
        {
            ImageKey = "schema";
            SelectedImageKey = "schema";
        }
    }
}
