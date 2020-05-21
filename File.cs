using System;
using System.Collections.Generic;
using System.Text;

namespace DbcFile
{
    class File
    {
        public string Version { get; set; }
        public List<string> NewSymbols { get; set; } = new List<string>
        {
            "NS_DESC_", "CM_", "BA_DEF_", "BA_", "VAL_", "CAT_DEF_", "CAT_", "FILTER", "BA_DEF_DEF_",
            "EV_DATA_", "ENVVAR_DATA_", "SGTYPE_", "SGTYPE_VAL_", "BA_DEF_SGTYPE_", "BA_SGTYPE_",
            "SIG_TYPE_REF_", "VAL_TABLE_", "SIG_GROUP_", "SIG_VALTYPE_", "SIGTYPE_VALTYPE_", "BO_TX_BU_",
            "BA_DEF_REL_", "BA_REL_", "BA_DEF_DEF_REL_", "BU_SG_REL_", "BU_EV_REL_", "BU_BO_REL_"
        };

        

        public List<Node> Nodes { get; set; } = new List<Node>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"VERSION \"{Version}\"{Environment.NewLine}{Environment.NewLine}");
            sb.Append($"NS_ :{Environment.NewLine}");
            foreach (var item in NewSymbols)
            {
                sb.Append($"  {item.ToString()}{Environment.NewLine}");
            }
            sb.Append($"BS_:{Environment.NewLine}{Environment.NewLine}");
            foreach (var item in Nodes)
            {
                sb.Append($"{item.ToString()}{Environment.NewLine}");
            }
            return sb.ToString();
        }
    }
}
