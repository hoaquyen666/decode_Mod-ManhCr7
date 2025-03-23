public class T34
{
	public static T42[] effTemplates;

	public static sbyte EFF_ME;

	public static sbyte EFF_FRIEND = 1;

	public int timeStart;

	public int timeLenght;

	public short param;

	public T42 template;

	public T34(sbyte templateId, int timeStart, int timeLenght, short param)
	{
		template = effTemplates[templateId];
		this.timeStart = timeStart;
		this.timeLenght = timeLenght / 1000;
		this.param = param;
	}
}
