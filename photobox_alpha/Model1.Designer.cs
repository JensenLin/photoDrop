﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.235
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// 原始檔案名稱:
// 產生日期: 2011/7/19 下午 10:56:52
namespace photobox_alpha
{
    
    /// <summary>
    /// 結構描述中沒有 Database1Entities 的註解。
    /// </summary>
    public partial class Database1Entities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// 使用應用程式組態檔 'Database1Entities' 區段中找到的連接字串初始化新的 Database1Entities 物件。
        /// </summary>
        public Database1Entities() : 
                base("name=Database1Entities", "Database1Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 Database1Entities 物件。
        /// </summary>
        public Database1Entities(string connectionString) : 
                base(connectionString, "Database1Entities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// 初始化新的 Database1Entities 物件。
        /// </summary>
        public Database1Entities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "Database1Entities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
    }
}