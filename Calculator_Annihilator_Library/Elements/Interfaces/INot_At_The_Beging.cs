namespace Calculator_Annihilator_Library
{
	/// <summary>
	/// Interface for elements that is not correct to place at the beginnig or end of the equation.
	/// </summary>
	interface INot_Outside_Of_Equation : INot_At_the_Begining, INot_At_The_End
	{

	}

	/// <summary>
	/// Interface for elements that is not correct to place at the beginnig of the equation.
	/// </summary>
	interface INot_At_the_Begining : IElement
	{

	}

	/// <summary>
	/// Interface for elements that is not correct to place at the end of the equation.
	/// </summary>
	interface INot_At_The_End : IElement
	{

	}
}
