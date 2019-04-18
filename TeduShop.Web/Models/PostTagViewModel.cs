using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {

        public int PostID { set; get; }

        public string TagID { set; get; }


        public virtual PostViewModel Post { set; get; }


        public virtual TagViewModel Tag { set; get; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }


        public string MetaKeyword { get; set; }


        public string MetaDescription { get; set; }

        public bool Status { get; set; }
    }
}