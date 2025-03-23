public class T151
{
	public int param;

	public T152 optionTemplate;

	public string optionString;

	public string M1771()
	{
		if (optionString == null)
		{
			optionString = T122.M1187(optionTemplate.name, "#", string.Empty + param);
		}
		return optionString;
	}
}
