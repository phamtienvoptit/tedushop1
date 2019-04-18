using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryViewModel)
        {
            postCategory.ID = postCategoryViewModel.ID;
            postCategory.Name = postCategoryViewModel.Name;
            postCategory.ParentID = postCategoryViewModel.ParentID;
            postCategory.Description = postCategoryViewModel.Description;
            postCategory.Alias = postCategoryViewModel.Alias;
            postCategory.DisplayOrder = postCategoryViewModel.DisplayOrder;
            postCategory.Image = postCategoryViewModel.Image;
            postCategory.HomeFlag = postCategoryViewModel.HomeFlag;

            postCategory.CreatedBy = postCategoryViewModel.CreatedBy;
            postCategory.CreatedDate = postCategoryViewModel.CreatedDate;
            postCategory.MetaDescription = postCategoryViewModel.MetaDescription;
            postCategory.MetaKeyword = postCategoryViewModel.MetaKeyword;
            postCategory.UpdatedBy = postCategoryViewModel.UpdatedBy;
            postCategory.UpdatedDate = postCategoryViewModel.UpdatedDate;
            postCategory.Status = postCategoryViewModel.Status;

        }
        public static void UpdatePost(this Post post, PostViewModel postViewModel)
        {
            post.ID = postViewModel.ID;
            post.HomeFlag = postViewModel.HomeFlag;
            post.HotFlag = postViewModel.HotFlag;
            post.Image = postViewModel.Image;
            post.Name = postViewModel.Name;
            post.Alias = postViewModel.Alias;
            post.Content = postViewModel.Content;
            post.CategoryID = postViewModel.CategoryID;
            post.Description = postViewModel.Description;
            post.ViewCount = postViewModel.ViewCount;

            post.CreatedBy = postViewModel.CreatedBy;
            post.CreatedDate = postViewModel.CreatedDate;
            post.MetaDescription = postViewModel.MetaDescription;
            post.MetaKeyword = postViewModel.MetaKeyword;
            post.UpdatedBy = postViewModel.UpdatedBy;
            post.UpdatedDate = postViewModel.UpdatedDate;
            post.Status = postViewModel.Status;

        }
    }
}