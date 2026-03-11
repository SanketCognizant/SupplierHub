using System;
using System.ComponentModel.DataAnnotations.Schema;
using SupplierHub.Constants;

namespace SupplierHub.Models
{
	[Table("Notification")]
	public class Notification
	{
		public long NotificationId { get; set; }
		public long UserId { get; set; }          // FK to Users table (IAM)

		public string Message { get; set; }       // Notification text
		public NotificationCategory Category { get; set; }
		public NotificationStatus Status { get; set; }

		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }
	}
}
