using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace ctOS.Library.Books
{
    /// <summary>
    /// 
    /// </summary>
    public class BookDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public string sKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sAuthor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sTag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sIntroduction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime tCreateDate { get; set; }
    }
}
