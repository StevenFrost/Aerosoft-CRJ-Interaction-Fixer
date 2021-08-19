using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AerosoftCRJInteractionFixer
{
	class ModelBehaviorModifications
	{
		[JsonPropertyName( "modifications" )]
		public List< Modification > Modifications { get; set; } = new List< Modification >();
	}

	class Modification
	{
		[JsonPropertyName( "button_id" )]
		public string ButtonId { get; set; } = "";

		[JsonPropertyName( "knob_id" )]
		public string KnobId { get; set; } = "";

		[JsonPropertyName( "knob_anim_name" )]
		public string KnobAnimName { get; set; } = "";

		[JsonPropertyName( "knob_change_name" )]
		public string KnobChangeName { get; set; } = "";

		[JsonPropertyName( "push_anim_name" )]
		public string PushAnimName { get; set; } = "";

		[JsonPropertyName( "push_name" )]
		public string PushName { get; set; } = "";
	}
}
