namespace Calculator_Annihilator
{
	/// <summary>
	/// Interface for elements that is not correct to place by outside of the bracket.
	/// </summary>
	interface INot_Outside_The_Bracket : INot_Outside_The_Open_Bracket, INot_Outside_The_Close_Bracket
	{

	}
	/// <summary>
	/// Interface for elements that is not correct to place before of the open bracket.
	/// </summary>
	interface INot_Outside_The_Open_Bracket : IElement
	{

	}
	/// <summary>
	/// Interface for elements that is not correct to place after of the close bracket.
	/// </summary>
	interface INot_Outside_The_Close_Bracket : IElement
	{

	}
}
