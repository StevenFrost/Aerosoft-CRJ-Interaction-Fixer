using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AerosoftCRJInteractionFixer
{
	class Manifest
	{
		[JsonPropertyName( "dependencies" )]
		public List< Dependency > Dependencies { get; set; } = new List< Dependency >();

		[JsonPropertyName( "content_type" )]
		public string ContentType { get; set; } = "";

		[JsonPropertyName( "title" )]
		public string Title { get; set; } = "";

		[JsonPropertyName( "manufacturer" )]
		public string Manufacturer { get; set; } = "";

		[JsonPropertyName( "creator" )]
		public string Creator { get; set; } = "";

		[JsonPropertyName( "package_version" )]
		public string PackageVersion { get; set; } = "";

		[JsonPropertyName( "minimum_game_version" )]
		public string MinimumGameVersion { get; set; } = "";

		[JsonPropertyName( "release_notes" )]
		public ReleaseNotes ReleaseNotes { get; set; } = new ReleaseNotes();
	}

	class Dependency
	{
		[JsonPropertyName( "name" )]
		public string PackageName { get; set; } = "";

		[JsonPropertyName( "package_version" )]
		public string PackageVersion { get; set; } = "";
	}

	class ReleaseNotes
	{
		[JsonPropertyName( "neutral" )]
		public ReleaseNote Neutral { get; set; } = new ReleaseNote();
	}

	class ReleaseNote
	{
		[JsonPropertyName( "LastUpdate" )]
		public string LastUpdate { get; set; } = "";

		[JsonPropertyName( "OlderHistory" )]
		public string OlderHistory { get; set; } = "";
	}
}
