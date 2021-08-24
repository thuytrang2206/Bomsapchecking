using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOM_SAP_CHECKING.MyClass
{
   public class List_result
    {
        public string Material_Number { get; set; }
        public string Assemble_Materialnumber { get; set; }
        public string Bom_Component { get; set; }
        public string AI_Group { get; set; }
        public string AI_Rankingorder { get; set; }
        public string AI_strategy { get; set; }
        public string Usage_probability { get; set; }
        public string Dis_indicator { get; set; }
        public string Dis_group { get; set; }
        public string Follow_up { get; set; }
        public string Qty { get; set; }
        public string Location { get; set; }
        public string Installation_position { get; set; }
    }
}
