public abstract class T74
{
	public abstract void paintDefaultBg(T99 g);

	public abstract void paintfillDefaultBg(T99 g);

	public abstract void repaintCircleBg();

	public abstract void paintSolidBg(T99 g);

	public abstract void paintDefaultPopup(T99 g, int x, int y, int w, int h);

	public abstract void paintWhitePopup(T99 g, int y, int x, int width, int height);

	public abstract void paintDefaultPopupH(T99 g, int h);

	public abstract void paintCmdBar(T99 g, T22 left, T22 center, T22 right);

	public abstract void paintSelect(T99 g, int x, int y, int w, int h);

	public abstract void paintLogo(T99 g, int x, int y);

	public abstract void paintHotline(T99 g, string num);

	public abstract void paintInputTf(T99 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text);

	public abstract void paintTabSoft(T99 g);

	public abstract void paintBackMenu(T99 g, int x, int y, int w, int h, bool iss);

	public abstract void paintMsgBG(T99 g, int x, int y, int w, int h, string title, string subTitle, string check);

	public abstract void paintDefaultScrLisst(T99 g, string title, string subTitle, string check);

	public abstract void paintCheck(T99 g, int x, int y, int index);

	public abstract void paintImgMsg(T99 g, int x, int y, int index);

	public abstract void paintTitleBoard(T99 g, int roomID);

	public abstract void paintCheckPass(T99 g, int x, int y, bool check, bool focus);

	public abstract void paintInputDlg(T99 g, int x, int y, int w, int h, string[] str);

	public abstract void paintIconMainMenu(T99 g, int x, int y, bool iss, bool issSe, int i, int wStr);

	public abstract void paintLineRoom(T99 g, int x, int y, int xTo, int yTo);

	public abstract void paintCellContaint(T99 g, int x, int y, int w, int h, bool iss);

	public abstract void paintScroll(T99 g, int x, int y, int h);

	public abstract int[] getColorMsg();

	public abstract void paintLogo(T99 g);

	public abstract void paintTextLogin(T99 g, bool issRes);

	public abstract void paintSellectBoard(T99 g, int x, int y, int w, int h);

	public abstract int issRegissterUsingWAP();

	public abstract string getCard();

	public abstract void paintSellectedShop(T99 g, int x, int y, int w, int h);

	public abstract string getUrlUpdateGame();

	public string M793()
	{
		return "http://wap.teamobi.com/faqs.php?provider=";
	}

	public abstract void doSelect(int focus);
}
