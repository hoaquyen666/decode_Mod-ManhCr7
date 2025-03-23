public interface T63
{
	void onMessage(T97 message);

	void onConnectionFail(bool isMain);

	void onDisconnected(bool isMain);

	void onConnectOK(bool isMain);
}
