﻿using System.Text.Json.Serialization;

namespace RadarrSharp.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class Language
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		[JsonPropertyName("id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}
