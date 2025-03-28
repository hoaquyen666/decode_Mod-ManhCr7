public class ItemOption
{
	public int param;

	public sbyte active;

	public sbyte activeCard;

	public ItemOptionTemplate optionTemplate;

	public ItemOption()
	{
	}

	public ItemOption(int optionTemplateId, int param)
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
		optionTemplate = GameScr.M559().iOptionTemplates[optionTemplateId];
	}

	public string M830()
	{
		return NinjaUtil.M1187(optionTemplate.name, "#", param + string.Empty);
	}

	public string M831()
	{
		return NinjaUtil.M1187(optionTemplate.name, "+#", string.Empty);
	}

	public string M832()
	{
		return NinjaUtil.M1187(optionTemplate.name, "$", string.Empty);
	}
}
