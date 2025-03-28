public class SkillOption
{
	public int param;

	public SkillOptionTemplate optionTemplate;

	public string optionString;

	public string M1771()
	{
		if (optionString == null)
		{
			optionString = NinjaUtil.M1187(optionTemplate.name, "#", string.Empty + param);
		}
		return optionString;
	}
}
