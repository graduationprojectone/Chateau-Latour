//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chateau_Latour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class F_Commoditypictures
    {
        public int CommoditypicturesId { get; set; }
        public string Picturedescription { get; set; }
        public string Mastergraph { get; set; }
        public string Pictureset { get; set; }
        public int CommodityId { get; set; }
    
        public virtual E_Commodity E_Commodity { get; set; }
    }
}
