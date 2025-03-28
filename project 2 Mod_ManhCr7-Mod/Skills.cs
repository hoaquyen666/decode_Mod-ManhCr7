public class Skills
{
	public static MyHashTable skills = new MyHashTable();

	public static void M1772(Skill skill)
	{
		skills.M1078(skill.skillId, skill);
	}

	public static Skill M1773(short skillId)
	{
		return (Skill)skills.M1074(skillId);
	}
}
