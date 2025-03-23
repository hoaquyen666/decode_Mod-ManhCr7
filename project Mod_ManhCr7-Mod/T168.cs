public class T168
{
	public int index;

	public int max;

	public short[] counts;

	public short taskId;

	public string[] names;

	public string[] details;

	public string[] subNames;

	public string[] contentInfo;

	public short count;

	public T168(short taskId, sbyte index, string name, string detail, string[] subNames, short[] counts, short count, string[] contentInfo)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.taskId = taskId;
		this.index = index;
		names = T98.tahoma_7b_green2.M907(name, T126.WIDTH_PANEL - 20);
		details = T98.tahoma_7.M907(detail, T126.WIDTH_PANEL - 20);
		this.subNames = subNames;
		this.counts = counts;
		this.count = count;
		this.contentInfo = contentInfo;
	}
}
