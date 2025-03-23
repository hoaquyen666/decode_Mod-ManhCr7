public class T82
{
	public int param;

	public sbyte active;

	public sbyte activeCard;

	public T83 optionTemplate;

	public T82()
	{
	}

	public T82(int optionTemplateId, int param)
	{
		if (optionTemplateId == 22)
		{
			optionTemplateId = 6;
			param *= 1000;
		}
		if (optionTemplateId == 23)
		{
			optionTemplateId = 7;
			param *= 1000;
		}
		this.param = param;
		optionTemplate = T54.M559().iOptionTemplates[optionTemplateId];
	}

	public string M830()
	{
		return T122.M1187(optionTemplate.name, "#", param + string.Empty);
	}

	public string M831()
	{
		return T122.M1187(optionTemplate.name, "+#", string.Empty);
	}

	public string M832()
	{
		return T122.M1187(optionTemplate.name, "$", string.Empty);
	}
}
