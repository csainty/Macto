using System;

namespace HibernatingRhinos.Macto.Models.Warrants
{
	public class SentencingWarrant : Warrant
	{
		public DateTime ExpiryDate { get; set; }	// Store along with duration for ease of querying
		public TimeSpan Duration { get; set; }		// Store along with expiry date for ease of review
	}
}