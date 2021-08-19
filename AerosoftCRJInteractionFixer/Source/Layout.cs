using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AerosoftCRJInteractionFixer
{
	class Layout
	{
		[JsonPropertyName( "content" )]
		public List< Content > Content { get; set; } = new List< Content >();
	}

	class Content
	{
		[JsonPropertyName( "path" )]
		public string Path { get; set; } = "";

		[JsonPropertyName( "size" )]
		public long Size { get; set; } = 0;

		[JsonPropertyName( "date" )]
		public long Date { get; set; } = 0;
	}
}
