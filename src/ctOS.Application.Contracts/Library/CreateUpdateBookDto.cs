using System;
using System.ComponentModel.DataAnnotations;

namespace ctOS.Library
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUpdateBookDto
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50)]
        public string sKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50)]
        public string sName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(200)]
        public string sLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50)]
        public string sAuthor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50)]
        public string sTag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Text)]
        public string sIntroduction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int tStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime tCreateDate { get; set; } = DateTime.Now;
    }
}
