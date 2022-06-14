﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ctOS.Library
{
    /// <summary>
    /// 
    /// </summary>
    public class Book : AuditedAggregateRoot<Guid>
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
