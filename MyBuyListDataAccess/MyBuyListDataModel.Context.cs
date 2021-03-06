﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBuyListDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyBuyListEntities : DbContext
    {
        public MyBuyListEntities()
            : base("name=MyBuyListEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<GeneralItem> GeneralItems { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MBLSetting> MBLSettings { get; set; }
        public virtual DbSet<MCategory> MCategories { get; set; }
        public virtual DbSet<MealRecipe> MealRecipes { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealType> MealTypes { get; set; }
        public virtual DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public virtual DbSet<MeasurementUnitsConvert> MeasurementUnitsConverts { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuType> MenuTypes { get; set; }
        public virtual DbSet<MissingListDetail> MissingListDetails { get; set; }
        public virtual DbSet<MissingList> MissingLists { get; set; }
        public virtual DbSet<NutCategory> NutCategories { get; set; }
        public virtual DbSet<NutItem> NutItems { get; set; }
        public virtual DbSet<NutValue> NutValues { get; set; }
        public virtual DbSet<ReciepList> ReciepLists { get; set; }
        public virtual DbSet<ReciepListDetail> ReciepListDetails { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<RecipesInShoppingList> RecipesInShoppingLists { get; set; }
        public virtual DbSet<SavedList> SavedLists { get; set; }
        public virtual DbSet<SavedListDetail> SavedListDetails { get; set; }
        public virtual DbSet<ShopDepartment> ShopDepartments { get; set; }
        public virtual DbSet<ShoppingListAdditionalItem> ShoppingListAdditionalItems { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserShoppingList> UserShoppingLists { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<DS_Forum> DS_Forum { get; set; }
        public virtual DbSet<DS_ForumAdmin> DS_ForumAdmin { get; set; }
        public virtual DbSet<DS_ForumLog> DS_ForumLog { get; set; }
        public virtual DbSet<DS_ForumMessages> DS_ForumMessages { get; set; }
        public virtual DbSet<RecipesFavorit> RecipesFavorits { get; set; }
        public virtual DbSet<ShoppingList> ShoppingLists { get; set; }
        public virtual DbSet<FoodConvertersList> FoodConvertersLists { get; set; }
        public virtual DbSet<RecipeIngredientsList> RecipeIngredientsLists { get; set; }
        public virtual DbSet<RecipesView> RecipesViews { get; set; }
    
        public virtual int DS_AddNewForum(string forumSubID, string forumHost, string forumName, ObjectParameter forumId)
        {
            var forumSubIDParameter = forumSubID != null ?
                new ObjectParameter("forumSubID", forumSubID) :
                new ObjectParameter("forumSubID", typeof(string));
    
            var forumHostParameter = forumHost != null ?
                new ObjectParameter("forumHost", forumHost) :
                new ObjectParameter("forumHost", typeof(string));
    
            var forumNameParameter = forumName != null ?
                new ObjectParameter("forumName", forumName) :
                new ObjectParameter("forumName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DS_AddNewForum", forumSubIDParameter, forumHostParameter, forumNameParameter, forumId);
        }
    
        public virtual int DS_DeleteMessage(Nullable<int> fID, Nullable<int> fMessageID)
        {
            var fIDParameter = fID.HasValue ?
                new ObjectParameter("FID", fID) :
                new ObjectParameter("FID", typeof(int));
    
            var fMessageIDParameter = fMessageID.HasValue ?
                new ObjectParameter("FMessageID", fMessageID) :
                new ObjectParameter("FMessageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DS_DeleteMessage", fIDParameter, fMessageIDParameter);
        }
    
        public virtual ObjectResult<DS_GetAdminMessages_Result> DS_GetAdminMessages(Nullable<int> forumId, Nullable<int> parentId)
        {
            var forumIdParameter = forumId.HasValue ?
                new ObjectParameter("forumId", forumId) :
                new ObjectParameter("forumId", typeof(int));
    
            var parentIdParameter = parentId.HasValue ?
                new ObjectParameter("parentId", parentId) :
                new ObjectParameter("parentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DS_GetAdminMessages_Result>("DS_GetAdminMessages", forumIdParameter, parentIdParameter);
        }
    
        public virtual ObjectResult<DS_GetForum_Result> DS_GetForum(string forumSubId)
        {
            var forumSubIdParameter = forumSubId != null ?
                new ObjectParameter("forumSubId", forumSubId) :
                new ObjectParameter("forumSubId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DS_GetForum_Result>("DS_GetForum", forumSubIdParameter);
        }
    
        public virtual ObjectResult<DS_GetMessages_Result> DS_GetMessages(Nullable<int> forumId)
        {
            var forumIdParameter = forumId.HasValue ?
                new ObjectParameter("forumId", forumId) :
                new ObjectParameter("forumId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DS_GetMessages_Result>("DS_GetMessages", forumIdParameter);
        }
    
        public virtual ObjectResult<DS_GetMessages2_Result> DS_GetMessages2(Nullable<int> forumId, Nullable<int> level)
        {
            var forumIdParameter = forumId.HasValue ?
                new ObjectParameter("forumId", forumId) :
                new ObjectParameter("forumId", typeof(int));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("level", level) :
                new ObjectParameter("level", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DS_GetMessages2_Result>("DS_GetMessages2", forumIdParameter, levelParameter);
        }
    
        public virtual ObjectResult<DS_GetMessagesBySearchValue_Result> DS_GetMessagesBySearchValue(string sEARCH_VALUE)
        {
            var sEARCH_VALUEParameter = sEARCH_VALUE != null ?
                new ObjectParameter("SEARCH_VALUE", sEARCH_VALUE) :
                new ObjectParameter("SEARCH_VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DS_GetMessagesBySearchValue_Result>("DS_GetMessagesBySearchValue", sEARCH_VALUEParameter);
        }
    
        public virtual int DS_InsertNewMessage(Nullable<int> fID, string fMessageTitle, string fMessageContent, string fMessageEmail, string fMessageSendMail, Nullable<int> fMessageParent, string fMessageDate, string fMessageTime, string fMessageOwner, string fMessageDesc1, string fMessageAddress1, string fMessageDesc2, string fMessageAddress2, string fMessageDesc3, string fMessageAddress3, string fMessageDesc4, string fMessageAddress4, string fMessageDesc5, string fMessageAddress5, string fMessageDesc6, string fMessageAddress6, ObjectParameter fMessageID)
        {
            var fIDParameter = fID.HasValue ?
                new ObjectParameter("FID", fID) :
                new ObjectParameter("FID", typeof(int));
    
            var fMessageTitleParameter = fMessageTitle != null ?
                new ObjectParameter("FMessageTitle", fMessageTitle) :
                new ObjectParameter("FMessageTitle", typeof(string));
    
            var fMessageContentParameter = fMessageContent != null ?
                new ObjectParameter("FMessageContent", fMessageContent) :
                new ObjectParameter("FMessageContent", typeof(string));
    
            var fMessageEmailParameter = fMessageEmail != null ?
                new ObjectParameter("FMessageEmail", fMessageEmail) :
                new ObjectParameter("FMessageEmail", typeof(string));
    
            var fMessageSendMailParameter = fMessageSendMail != null ?
                new ObjectParameter("FMessageSendMail", fMessageSendMail) :
                new ObjectParameter("FMessageSendMail", typeof(string));
    
            var fMessageParentParameter = fMessageParent.HasValue ?
                new ObjectParameter("FMessageParent", fMessageParent) :
                new ObjectParameter("FMessageParent", typeof(int));
    
            var fMessageDateParameter = fMessageDate != null ?
                new ObjectParameter("FMessageDate", fMessageDate) :
                new ObjectParameter("FMessageDate", typeof(string));
    
            var fMessageTimeParameter = fMessageTime != null ?
                new ObjectParameter("FMessageTime", fMessageTime) :
                new ObjectParameter("FMessageTime", typeof(string));
    
            var fMessageOwnerParameter = fMessageOwner != null ?
                new ObjectParameter("FMessageOwner", fMessageOwner) :
                new ObjectParameter("FMessageOwner", typeof(string));
    
            var fMessageDesc1Parameter = fMessageDesc1 != null ?
                new ObjectParameter("FMessageDesc1", fMessageDesc1) :
                new ObjectParameter("FMessageDesc1", typeof(string));
    
            var fMessageAddress1Parameter = fMessageAddress1 != null ?
                new ObjectParameter("FMessageAddress1", fMessageAddress1) :
                new ObjectParameter("FMessageAddress1", typeof(string));
    
            var fMessageDesc2Parameter = fMessageDesc2 != null ?
                new ObjectParameter("FMessageDesc2", fMessageDesc2) :
                new ObjectParameter("FMessageDesc2", typeof(string));
    
            var fMessageAddress2Parameter = fMessageAddress2 != null ?
                new ObjectParameter("FMessageAddress2", fMessageAddress2) :
                new ObjectParameter("FMessageAddress2", typeof(string));
    
            var fMessageDesc3Parameter = fMessageDesc3 != null ?
                new ObjectParameter("FMessageDesc3", fMessageDesc3) :
                new ObjectParameter("FMessageDesc3", typeof(string));
    
            var fMessageAddress3Parameter = fMessageAddress3 != null ?
                new ObjectParameter("FMessageAddress3", fMessageAddress3) :
                new ObjectParameter("FMessageAddress3", typeof(string));
    
            var fMessageDesc4Parameter = fMessageDesc4 != null ?
                new ObjectParameter("FMessageDesc4", fMessageDesc4) :
                new ObjectParameter("FMessageDesc4", typeof(string));
    
            var fMessageAddress4Parameter = fMessageAddress4 != null ?
                new ObjectParameter("FMessageAddress4", fMessageAddress4) :
                new ObjectParameter("FMessageAddress4", typeof(string));
    
            var fMessageDesc5Parameter = fMessageDesc5 != null ?
                new ObjectParameter("FMessageDesc5", fMessageDesc5) :
                new ObjectParameter("FMessageDesc5", typeof(string));
    
            var fMessageAddress5Parameter = fMessageAddress5 != null ?
                new ObjectParameter("FMessageAddress5", fMessageAddress5) :
                new ObjectParameter("FMessageAddress5", typeof(string));
    
            var fMessageDesc6Parameter = fMessageDesc6 != null ?
                new ObjectParameter("FMessageDesc6", fMessageDesc6) :
                new ObjectParameter("FMessageDesc6", typeof(string));
    
            var fMessageAddress6Parameter = fMessageAddress6 != null ?
                new ObjectParameter("FMessageAddress6", fMessageAddress6) :
                new ObjectParameter("FMessageAddress6", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DS_InsertNewMessage", fIDParameter, fMessageTitleParameter, fMessageContentParameter, fMessageEmailParameter, fMessageSendMailParameter, fMessageParentParameter, fMessageDateParameter, fMessageTimeParameter, fMessageOwnerParameter, fMessageDesc1Parameter, fMessageAddress1Parameter, fMessageDesc2Parameter, fMessageAddress2Parameter, fMessageDesc3Parameter, fMessageAddress3Parameter, fMessageDesc4Parameter, fMessageAddress4Parameter, fMessageDesc5Parameter, fMessageAddress5Parameter, fMessageDesc6Parameter, fMessageAddress6Parameter, fMessageID);
        }
    
        public virtual int DS_SetMessageStatus(Nullable<int> fID, Nullable<int> fMessageID, Nullable<bool> active)
        {
            var fIDParameter = fID.HasValue ?
                new ObjectParameter("FID", fID) :
                new ObjectParameter("FID", typeof(int));
    
            var fMessageIDParameter = fMessageID.HasValue ?
                new ObjectParameter("FMessageID", fMessageID) :
                new ObjectParameter("FMessageID", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DS_SetMessageStatus", fIDParameter, fMessageIDParameter, activeParameter);
        }
    
        public virtual int DS_UpdateMessage(Nullable<int> fID, Nullable<int> fMessageID, string cONTENT)
        {
            var fIDParameter = fID.HasValue ?
                new ObjectParameter("FID", fID) :
                new ObjectParameter("FID", typeof(int));
    
            var fMessageIDParameter = fMessageID.HasValue ?
                new ObjectParameter("FMessageID", fMessageID) :
                new ObjectParameter("FMessageID", typeof(int));
    
            var cONTENTParameter = cONTENT != null ?
                new ObjectParameter("CONTENT", cONTENT) :
                new ObjectParameter("CONTENT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DS_UpdateMessage", fIDParameter, fMessageIDParameter, cONTENTParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int spAddFavoritReciep(Nullable<int> recipeId, Nullable<int> userId)
        {
            var recipeIdParameter = recipeId.HasValue ?
                new ObjectParameter("RecipeId", recipeId) :
                new ObjectParameter("RecipeId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddFavoritReciep", recipeIdParameter, userIdParameter);
        }
    
        public virtual int spAddMenuItemsToShoppingList(Nullable<int> userId, Nullable<int> menuId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var menuIdParameter = menuId.HasValue ?
                new ObjectParameter("menuId", menuId) :
                new ObjectParameter("menuId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddMenuItemsToShoppingList", userIdParameter, menuIdParameter);
        }
    
        public virtual int spAddMenuToShoppingList(Nullable<int> userId, Nullable<int> menuId, Nullable<bool> add)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var menuIdParameter = menuId.HasValue ?
                new ObjectParameter("MenuId", menuId) :
                new ObjectParameter("MenuId", typeof(int));
    
            var addParameter = add.HasValue ?
                new ObjectParameter("Add", add) :
                new ObjectParameter("Add", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddMenuToShoppingList", userIdParameter, menuIdParameter, addParameter);
        }
    
        public virtual int spAddMissingListToShoppingList(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddMissingListToShoppingList", userIdParameter);
        }
    
        public virtual int spAddRecipeInShoopingList(Nullable<int> recipeId, Nullable<int> servings, Nullable<int> userId, Nullable<bool> add)
        {
            var recipeIdParameter = recipeId.HasValue ?
                new ObjectParameter("RecipeId", recipeId) :
                new ObjectParameter("RecipeId", typeof(int));
    
            var servingsParameter = servings.HasValue ?
                new ObjectParameter("Servings", servings) :
                new ObjectParameter("Servings", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var addParameter = add.HasValue ?
                new ObjectParameter("Add", add) :
                new ObjectParameter("Add", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddRecipeInShoopingList", recipeIdParameter, servingsParameter, userIdParameter, addParameter);
        }
    
        public virtual int spAddSavedListItemsToShoppingList(Nullable<int> listId, Nullable<int> userId)
        {
            var listIdParameter = listId.HasValue ?
                new ObjectParameter("ListId", listId) :
                new ObjectParameter("ListId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddSavedListItemsToShoppingList", listIdParameter, userIdParameter);
        }
    
        public virtual int spAddSavedListToShoppingList(Nullable<int> listId, Nullable<int> userId)
        {
            var listIdParameter = listId.HasValue ?
                new ObjectParameter("ListId", listId) :
                new ObjectParameter("ListId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddSavedListToShoppingList", listIdParameter, userIdParameter);
        }
    
        public virtual int spAddToMissingList(Nullable<int> userId, Nullable<int> foodId, Nullable<int> measureTypeId, Nullable<int> quantity)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var foodIdParameter = foodId.HasValue ?
                new ObjectParameter("foodId", foodId) :
                new ObjectParameter("foodId", typeof(int));
    
            var measureTypeIdParameter = measureTypeId.HasValue ?
                new ObjectParameter("measureTypeId", measureTypeId) :
                new ObjectParameter("measureTypeId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddToMissingList", userIdParameter, foodIdParameter, measureTypeIdParameter, quantityParameter);
        }
    
        public virtual int spAddToSavedList(Nullable<int> savedListId, Nullable<int> itemId, Nullable<int> measureTypeId, Nullable<int> quantity)
        {
            var savedListIdParameter = savedListId.HasValue ?
                new ObjectParameter("savedListId", savedListId) :
                new ObjectParameter("savedListId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(int));
    
            var measureTypeIdParameter = measureTypeId.HasValue ?
                new ObjectParameter("measureTypeId", measureTypeId) :
                new ObjectParameter("measureTypeId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddToSavedList", savedListIdParameter, itemIdParameter, measureTypeIdParameter, quantityParameter);
        }
    
        public virtual int spAddToShoppingList(Nullable<int> userId, string items)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("userId", userId) :
                new ObjectParameter("userId", typeof(int));
    
            var itemsParameter = items != null ?
                new ObjectParameter("items", items) :
                new ObjectParameter("items", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddToShoppingList", userIdParameter, itemsParameter);
        }
    
        public virtual int spDeleteFromMissingList(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteFromMissingList", idParameter);
        }
    
        public virtual int spDeleteSavedListItem(Nullable<int> itemId)
        {
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("itemId", itemId) :
                new ObjectParameter("itemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteSavedListItem", itemIdParameter);
        }
    
        public virtual ObjectResult<spGetFavoritRecipes_Result> spGetFavoritRecipes(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetFavoritRecipes_Result>("spGetFavoritRecipes", userIdParameter);
        }
    
        public virtual ObjectResult<spGetItems_Result> spGetItems(string value)
        {
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetItems_Result>("spGetItems", valueParameter);
        }
    
        public virtual int spGetSelectedRecipes(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spGetSelectedRecipes", userIdParameter);
        }
    
        public virtual int spNewSavedList(string name, Nullable<int> created_by)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spNewSavedList", nameParameter, created_byParameter);
        }
    
        public virtual int spRemoveFavoritReciep(Nullable<int> recipeId, Nullable<int> userID)
        {
            var recipeIdParameter = recipeId.HasValue ?
                new ObjectParameter("RecipeId", recipeId) :
                new ObjectParameter("RecipeId", typeof(int));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRemoveFavoritReciep", recipeIdParameter, userIDParameter);
        }
    
        public virtual int spRemoveSavedList(Nullable<int> listId)
        {
            var listIdParameter = listId.HasValue ?
                new ObjectParameter("listId", listId) :
                new ObjectParameter("listId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRemoveSavedList", listIdParameter);
        }
    
        public virtual ObjectResult<spShoppingList_Result> spShoppingList(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spShoppingList_Result>("spShoppingList", userIdParameter);
        }
    
        public virtual int spUpdateMissingList(Nullable<int> id, Nullable<int> quantity)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateMissingList", idParameter, quantityParameter);
        }
    
        public virtual int spUpdateSavedList(Nullable<int> id, Nullable<int> quantity)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateSavedList", idParameter, quantityParameter);
        }
    
        public virtual int spCheckShoppingListItem(Nullable<int> userId, Nullable<int> foodId, Nullable<bool> active)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var foodIdParameter = foodId.HasValue ?
                new ObjectParameter("FoodId", foodId) :
                new ObjectParameter("FoodId", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCheckShoppingListItem", userIdParameter, foodIdParameter, activeParameter);
        }
    
        public virtual ObjectResult<spGetMissingsList_Result> spGetMissingsList(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetMissingsList_Result>("spGetMissingsList", userIdParameter);
        }
    
        public virtual ObjectResult<spGetSelectedMenus_Result> spGetSelectedMenus(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetSelectedMenus_Result>("spGetSelectedMenus", userIdParameter);
        }
    }
}
